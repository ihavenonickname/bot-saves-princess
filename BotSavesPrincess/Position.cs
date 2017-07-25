using System;

namespace BotSavesPrincess
{
    class Position
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override int GetHashCode()
        {
            var hash = 17;

            hash = hash * 23 + Row;
            hash = hash * 23 + Column;

            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Position))
            {
                return false;
            }

            var other = (Position)obj;

            return other.Row == Row && other.Column == Column;
        }

        public static bool operator==(Position pos1, Position pos2)
        {
            if ((object)pos1 == null && (object)pos2 == null)
            {
                return true;
            }

            try
            {
                return pos1.Equals(pos2);
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public static bool operator !=(Position pos1, Position pos2)
        {
            return !(pos1 == pos2);
        }
    }
}
