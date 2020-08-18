using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SearchNearBy
{
    public partial class Form1 : Form
    {
        private const int PointSize = 5;
        private List<Position> _positions;
        private Bitmap _basedMap;

        public Form1()
        {
            InitializeComponent();
            gvPositions.EditMode = DataGridViewEditMode.EditOnF2;
            gvPositions.AllowUserToAddRows = false;
            gvPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvPositions.CellFormatting += GvPositionsOnCellFormatting;

            pnMap.BorderStyle = BorderStyle.FixedSingle;

            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            // Go from Top-Left (0, 0)
            pb.Location = new Point(0, 0);

            lbZoneValue.Text = "0";
            var searchZoneLimit = Convert.ToInt32(Math.Sqrt(Math.Pow(pb.Height, 2) + Math.Pow(pb.Width, 2)));
            sbSearchZone.Maximum = searchZoneLimit;
            sbSearchZone.Value = searchZoneLimit;
            sbSearchZone.Scroll += SbFindZoneOnScroll;
            btnRandom.Click += RandomButtonClicked;

            RandomLocations();
            LoadLocationsToMap();
        }

        private void RandomButtonClicked(object sender, EventArgs e)
        {
            RandomLocations();
            LoadLocationsToMap();
        }

        private void SbFindZoneOnScroll(object sender, ScrollEventArgs e)
        {
            var targetLocation = _positions.First(po => po.IsTarget);

            var map = (Bitmap)_basedMap.Clone();

            using (var gr = Graphics.FromImage(map))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                var searchRadius = sbSearchZone.Maximum - sbSearchZone.Value;
                lbZoneValue.Text = searchRadius.ToString();

                var searchRectangle = targetLocation.GetRectangle(searchRadius * 2);

                var searchedPositions = _positions.Where(p => targetLocation.Type == p.Type && searchRectangle.Contains(p.X, p.Y));

                if (searchedPositions.Any())
                {
                    if (TryGetColor(targetLocation.Type, out var brush, out var color))
                    {
                        var found = 0;

                        foreach (var position in searchedPositions)
                        {
                            if (position == targetLocation) continue;

                            var distanceInPixel = targetLocation.GetDistanceTo(position);

                            if (distanceInPixel > searchRadius) continue;

                            found++;
                            using (var pointPen = new Pen(color, PointSize * 2))
                            {
                                var point = position.GetRectangle(PointSize);
                                gr.FillEllipse(brush, point);
                                gr.DrawEllipse(pointPen, point);
                            }
                        }

                        lbFound.Text = found.ToString();
                        using (var positionZonePen = new Pen(color, 1))
                        {
                            gr.DrawEllipse(positionZonePen, searchRectangle);
                        }
                    }
                }
            }

            pb.Image = map;
        }

        private void GvPositionsOnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gvPositions.Columns[e.ColumnIndex].Name.Equals("Type"))
            {
                var cell = gvPositions.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value is null) return;

                var positionType = (PositionType)Enum.Parse(typeof(PositionType), cell.Value.ToString());

                if (TryGetColor(positionType, out var brush, out var color))
                {
                    cell.Style.BackColor = color;
                }
            }
        }

        private void LoadLocationsToMap()
        {
            _basedMap = new Bitmap(pb.Width, pb.Height);

            using (var gr = Graphics.FromImage(_basedMap))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.FillRectangle(Brushes.White, new Rectangle(0, 0, _basedMap.Width, _basedMap.Height));

                foreach (DataGridViewRow row in gvPositions.Rows)
                {
                    var position = (Position)row;

                    if (TryGetColor(position.Type, out var brush, out var color))
                    {
                        using (var pointPen = new Pen(color, PointSize))
                        {
                            var point = position.GetRectangle(PointSize);
                            gr.FillEllipse(brush, point);
                            gr.DrawEllipse(pointPen, point);
                        }
                    }
                }
            }

            pb.Image = (Image)_basedMap.Clone();
        }

        private bool TryGetColor(PositionType positionType, out Brush brush, out Color color)
        {
            switch (positionType)
            {
                case PositionType.Company:
                    color = Color.Red; break;

                case PositionType.Hotel:
                    color = Color.Chocolate; break;

                case PositionType.School:
                    color = Color.ForestGreen; break;

                case PositionType.Restaurant:
                    color = Color.Orange; break;

                case PositionType.Park:
                    color = Color.Blue; break;

                default:
                    color = Color.Transparent; break;
            }

            if (color != null)
            {
                brush = new SolidBrush(color);
                return true;
            }
            
            brush = null;
            return false;
        }

        private void RandomLocations()
        {
            _positions = new List<Position>();
            var random = new Random();
            var maxPositionRandom = (int)Enum.GetValues(typeof(PositionType)).Cast<PositionType>().Last() + 1;

            Enumerable.Range(0, (int)numRandom.Value).ToList().ForEach(num =>
            {
                var x = random.Next(5, pb.Width);
                var y = random.Next(5, pb.Height);

                var type = (PositionType)random.Next(1, maxPositionRandom);
                _positions.Add(new Position
                {
                    X = x,
                    Y = y,
                    Type = type
                });
            });

            _positions[random.Next(0, _positions.Count)].IsTarget = true;

            gvPositions.DataSource = new BindingSource
            {
                DataSource = _positions
            };
        }
    }
}