using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotSavesPrincess
{
    class PathHistory
    {
        private readonly Dictionary<Position, Position> _memory = new Dictionary<Position, Position>();

        public void Update(Position fromPosition, Position toPosition)
        {
            _memory[fromPosition] = toPosition;
        }

        public IEnumerable<Position> Build(Position start, Position target)
        {
            var current = target;

            while (true)
            {
                current = _memory[current];

                if (current == start)
                {
                    break;
                }

                yield return current;
            }
        }
    }
}
