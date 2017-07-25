using System;
using System.Collections.Generic;
using System.Linq;

namespace BotSavesPrincess
{
    class Finder
    {
        private readonly int _lastRow;
        private readonly int _lastColumn;

        public Finder(int lastRow, int lastColumn)
        {
            _lastRow = lastRow;
            _lastColumn = lastColumn;
        }

        public List<Position> findPath(Position start, Position target, HashSet<Position> nonReachable)
        {
            var visitedPositions = new HashSet<Position>(nonReachable);

            var availablePositions = new HashSet<Position>();

            availablePositions.Add(start);

            var previousPosition = new Dictionary<Position, Position>();

            var actualScore = new Dictionary<Position, double>();

            actualScore[start] = 0;

            var estimatedScore = new Dictionary<Position, double>();

            estimatedScore[start] = estimateDistance(start, target);

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
                    var path = new List<Position>();

                    while (true)
                    {
                        current = previousPosition[current];

                        if (current == start)
                        {
                            return path;
                        }

                        path.Add(current);
                    }
                }

                availablePositions.Remove(current);

                visitedPositions.Add(current);

                foreach (var neighbor in neighborhood(current))
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

                    var attemptScore = actualScore[current] + estimateDistance(current, neighbor);

                    if (!actualScore.ContainsKey(neighbor))
                    {
                        actualScore[neighbor] = 999999;
                    }

                    if (attemptScore < actualScore[neighbor])
                    {
                        previousPosition[neighbor] = current;
                        actualScore[neighbor] = attemptScore;
                        estimatedScore[neighbor] = actualScore[neighbor] + estimateDistance(neighbor, target);
                    }
                }
            }

            return null;
        }

        private IEnumerable<Position> neighborhood(Position pos)
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

        private double estimateDistance(Position pos, Position target)
        {
            var difRow = target.Row - pos.Row;
            var difCol = target.Column - pos.Column;

            return Math.Sqrt(Math.Pow(difRow, 2) + Math.Pow(difCol, 2));            
        }
    }
}
