using System;
using System.Collections.Generic;
using System.Linq;

namespace BotSavesPrincess_Core
{
    public class RandomPathFinder : IPathFinder
    {
        public IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable, INeighborhood neighborGenerator)
        {
            var random = new Random();

            var visitedPositions = new HashSet<Position>(nonReachable);

            var path = new Stack<Position>();

            var current = start;

            visitedPositions.Add(current);

            while (true)
            {
                var neighbors = neighborGenerator.Neighbors(current);

                var nonVisitedneighbors = neighbors.Where(x => !visitedPositions.Contains(x)).ToArray();

                if (nonVisitedneighbors.Any())
                {
                    var someNeighbor = nonVisitedneighbors[random.Next(nonVisitedneighbors.Count())];

                    path.Push(current);

                    current = someNeighbor;

                    visitedPositions.Add(someNeighbor);

                    if (someNeighbor == target)
                    {
                        return path.Reverse().Skip(1);
                    }
                }
                else
                {
                    if (!path.Any())
                    {
                        return null;
                    }

                    current = path.Pop();
                }
            }
        }

        public override string ToString()
        {
            return "Random";
        }
    }
}
