using System;
using System.Collections.Generic;
using System.Linq;

namespace BotSavesPrincess_Core
{
    public class ShortestPathFinder : IPathFinder
    {
        public IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable, INeighborhood neighborGenerator)
        {
            var visitedPositions = new HashSet<Position>(nonReachable);

            var availablePositions = new HashSet<Position>();

            availablePositions.Add(start);

            var path = new Path();

            var actualScore = new Dictionary<Position, double>();

            actualScore[start] = 0;

            var estimatedScore = new Dictionary<Position, double>();

            estimatedScore[start] = EstimateDistance(start, target);

            while (availablePositions.Any())
            {
                Position current = null;

                foreach (var pos in availablePositions.Intersect(estimatedScore.Keys))
                {
                    if (current == null)
                    {
                        current = pos;
                    }

                    if (estimatedScore[pos] < estimatedScore[current])
                    {
                        current = pos;
                    }
                }

                if (current == target)
                {
                    return path.Build(start, target);
                }

                availablePositions.Remove(current);

                visitedPositions.Add(current);

                foreach (var neighbor in neighborGenerator.Neighbors(current))
                {
                    if (visitedPositions.Contains(neighbor))
                    {
                        continue;
                    }

                    availablePositions.Add(neighbor);

                    if (!actualScore.ContainsKey(current))
                    {
                        actualScore[current] = 999999;
                    }

                    var attemptScore = actualScore[current] + EstimateDistance(current, neighbor);

                    if (!actualScore.ContainsKey(neighbor))
                    {
                        actualScore[neighbor] = 999999;
                    }

                    if (attemptScore < actualScore[neighbor])
                    {
                        path.Update(neighbor, current);
                        actualScore[neighbor] = attemptScore;
                        estimatedScore[neighbor] = actualScore[neighbor] + EstimateDistance(neighbor, target);
                    }
                }
            }

            return null;
        }
        
        private double EstimateDistance(Position pos, Position target)
        {
            var difRow = target.Row - pos.Row;
            var difCol = target.Column - pos.Column;

            return Math.Sqrt(Math.Pow(difRow, 2) + Math.Pow(difCol, 2));            
        }

        public override string ToString()
        {
            return "Shortest";
        }
    }
}
