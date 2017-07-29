using System.Collections.Generic;

namespace Core
{
    public class UDLRNeighborhood : INeighborhood
    {
        private readonly int _lastRow;
        private readonly int _lastColumn;

        public UDLRNeighborhood(int lastRow, int lastColumn)
        {
            _lastRow = lastRow;
            _lastColumn = lastColumn;
        }

        public IEnumerable<Position> Neighbors(Position pos)
        {
            if (pos.Row > 0)
            {
                yield return new Position(pos.Row - 1, pos.Column);
            }

            if (pos.Row < _lastRow)
            {
                yield return new Position(pos.Row + 1, pos.Column);
            }

            if (pos.Column > 0)
            {
                yield return new Position(pos.Row, pos.Column - 1);
            }

            if (pos.Column < _lastColumn)
            {
                yield return new Position(pos.Row, pos.Column + 1);
            }
        }

        public override string ToString()
        {
            return "Up Down Left Right";
        }
    }
}
