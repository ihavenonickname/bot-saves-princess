using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class SemiRandomPathFinder : IPathFinder
    {
        public IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable, INeighborhood neighborGenerator)
        {
            var random = new Random();

            var availablePositions = new List<Position>();
            var visitedPositions = new HashSet<Position>(nonReachable);
            var path = new Path();

            availablePositions.Add(start);

            while (availablePositions.Any())
            {
                var index = random.Next(availablePositions.Count);

                var current = availablePositions[index];

                availablePositions.RemoveAt(index);

                if (current == target)
                {
                    return path.Build(start, target);
                }

                visitedPositions.Add(current);

                foreach (var neighbor in neighborGenerator.Neighbors(current))
                {
                    if (!visitedPositions.Contains(neighbor))
                    {
                        availablePositions.Add(neighbor);
                        path.Update(neighbor, current);
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
