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

        public List<Position> findPath(Position start, Position target, HashSet<Position> nonWalkable)
        {
            var closedSet = new HashSet<Position>(nonWalkable);

            var openSet = new HashSet<Position>();

            openSet.Add(start);

            var cameFrom = new Dictionary<Position, Position>();

            var gScore = new Dictionary<Position, double>();

            gScore[start] = 0;

            var fScore = new Dictionary<Position, double>();

            fScore[start] = distance(start, target);

            while (openSet.Any())
            {
                Position current = null;

                foreach (var pos in openSet.Intersect(fScore.Keys))
                {
                    if (current == null)
                    {
                        current = pos;
                    }

                    if (fScore[pos] < fScore[current])
                    {
                        current = pos;
                    }
                }

                if (current == target)
                {
                    var path = new List<Position>();

                    while (true)
                    {
                        current = cameFrom[current];

                        if (current == start)
                        {
                            return path;
                        }

                        path.Add(current);
                    }
                }

                openSet.Remove(current);

                closedSet.Add(current);

                foreach (var neighbor in neighborhood(current))
                {
                    if (closedSet.Contains(neighbor))
                    {
                        continue;
                    }

                    openSet.Add(neighbor);

                    if (!gScore.ContainsKey(current))
                    {
                        gScore[current] = 999999;
                    }

                    var tentativeScore = gScore[current] + distance(current, neighbor);

                    if (!gScore.ContainsKey(neighbor))
                    {
                        gScore[neighbor] = 999999;
                    }

                    if (tentativeScore < gScore[neighbor])
                    {
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentativeScore;
                        fScore[neighbor] = gScore[neighbor] + distance(neighbor, target);
                    }
                }
            }

            return null;
        }

        private List<Position> neighborhood(Position pos)
        {
            var neighbors = new List<Position>();

            if (pos.Row > 0)
            {
                neighbors.Add(new Position(pos.Row - 1, pos.Column));
            }

            if (pos.Row < _lastRow)
            {
                neighbors.Add(new Position(pos.Row + 1, pos.Column));
            }

            if (pos.Column > 0)
            {
                neighbors.Add(new Position(pos.Row, pos.Column - 1));
            }

            if (pos.Column < _lastColumn)
            {
                neighbors.Add(new Position(pos.Row, pos.Column + 1));
            }

            return neighbors;
        }

        private double distance(Position pos, Position target)
        {
            var difRow = target.Row - pos.Row;
            var difCol = target.Column - pos.Column;

            return Math.Sqrt(Math.Pow(difRow, 2) + Math.Pow(difCol, 2));            
        }
    }
}
