using System;
using System.Windows.Forms;

namespace SearchNearBy
{
    public partial class Position
    {
        public static explicit operator Position(DataGridViewRow row)
        {
            var left = row.Cells[0].Value;
            var top = row.Cells[1].Value;
            var type = row.Cells[2].Value.ToString();
            var isTarget = row.Cells[3].Value;

            return new Position
            {
                X = Convert.ToInt32(left),
                Y = Convert.ToInt32(top),
                Type = (PositionType)Enum.Parse(typeof(PositionType), type),
                IsTarget = Convert.ToBoolean(isTarget)
            };

        }
    }
}
