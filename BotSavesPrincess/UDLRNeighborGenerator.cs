using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotSavesPrincess
{
    class UDLRNeighborGenerator : INeighborGenerator
    {
        private readonly int _lastRow;
        private readonly int _lastColumn;

        public UDLRNeighborGenerator(int lastRow, int lastColumn)
        {
            _lastRow = lastRow;
            _lastColumn = lastColumn;
        }

        public IEnumerable<Position> Neighborhood(Position pos)
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
    }
}
