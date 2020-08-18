using System;
using System.Drawing;

namespace SearchNearBy
{
    /// <summary>
    /// Just accept X,Y as pixel unit
    /// </summary>
    public partial class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PositionType Type { get; set; }

        public bool IsTarget { get; set; }

        public RectangleF GetRectangle(int diameter)
        {
            return new RectangleF(X - (diameter / 2), Y - (diameter / 2), diameter, diameter);
        }

        public decimal GetDistanceTo(Position destination)
        {
            var pixelDistance = (decimal)Math.Sqrt(Math.Pow(X - destination.X, 2) + Math.Pow(Y - destination.Y, 2));

            return pixelDistance;
        }
    }
}
