using System.Collections.Generic;

namespace Core
{
    public class OctagonalNeighborhood : INeighborhood
    {
        private readonly int _lastRow;
        private readonly int _lastColumn;

        public OctagonalNeighborhood(int lastRow, int lastColumn)
        {
            _lastRow = lastRow;
            _lastColumn = lastColumn;
        }

        public IEnumerable<Position> Neighbors(Position pos)
        {
            // | 1 | 2 | 3 |
            // | 4 | X | 5 |
            // | 6 | 7 | 8 |

            // 1
            if (pos.Row > 0 && pos.Column > 0)
            {
                yield return new Position(pos.Row - 1, pos.Column - 1);
            }

            // 2
            if (pos.Row > 0)
            {
                yield return new Position(pos.Row - 1, pos.Column);
            }

            // 3
            if (pos.Row > 0 && pos.Column < _lastColumn)
            {
                yield return new Position(pos.Row - 1, pos.Column + 1);
            }

            // 4
            if (pos.Column > 0)
            {
                yield return new Position(pos.Row, pos.Column - 1);
            }

            // 5
            if (pos.Column < _lastColumn)
            {
                yield return new Position(pos.Row, pos.Column + 1);
            }
            
            // 6
            if (pos.Row < _lastRow && pos.Column > 0)
            {
                yield return new Position(pos.Row + 1, pos.Column - 1);
            }

            // 7
            if (pos.Row < _lastRow)
            {
                yield return new Position(pos.Row + 1, pos.Column);
            }

            // 8
            if (pos.Column < _lastColumn && pos.Row < _lastRow)
            {
                yield return new Position(pos.Row + 1, pos.Column + 1);
            }
        }

        public override string ToString()
        {
            return "Octagonal";
        }
    }
}
