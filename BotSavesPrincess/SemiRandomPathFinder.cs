using System;
using System.Collections.Generic;
using System.Linq;

namespace BotSavesPrincess
{
    class SemiRandomPathFinder : IFinder
    {
        private readonly INeighborGenerator _neighborGenerator;

        public SemiRandomPathFinder(INeighborGenerator neighborGenerator)
        {
            _neighborGenerator = neighborGenerator;
        }

        public IEnumerable<Position> FindPath(Position start, Position target)
        {
            return FindPath(start, target, new HashSet<Position>());
        }

        public IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable)
        {
            var random = new Random();

            var availablePositions = new List<Position>();
            var visitedPositions = new HashSet<Position>(nonReachable);
            var history = new PathHistory();

            availablePositions.Add(start);

            while (availablePositions.Any())
            {
                var index = random.Next(availablePositions.Count);

                var current = availablePositions[index];

                availablePositions.RemoveAt(index);

                if (current == target)
                {
                    return history.Build(start, target).Reverse();
                }

                visitedPositions.Add(current);

                foreach (var neighbor in _neighborGenerator.Neighborhood(current))
                {
                    if (!visitedPositions.Contains(neighbor))
                    {
                        availablePositions.Add(neighbor);
                        history.Update(neighbor, current);
                    }
                }
            }

            return null;
        }

        public override string ToString()
        {
            return "Semi-random";
        }
    }
}
