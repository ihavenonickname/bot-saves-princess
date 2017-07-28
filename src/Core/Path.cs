using System.Collections.Generic;

namespace BotSavesPrincess_Core
{
    public class Path
    {
        private readonly Dictionary<Position, Position> _memory = new Dictionary<Position, Position>();

        public void Update(Position fromPosition, Position toPosition)
        {
            _memory[fromPosition] = toPosition;
        }

        public IEnumerable<Position> Build(Position start, Position target)
        {
            var positions = new Stack<Position>();

            var current = target;

            while (true)
            {
                current = _memory[current];

                if (current == start)
                {
                    return positions;
                }

                positions.Push(current);
            }
        }
    }
}
