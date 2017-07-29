using System.Collections.Generic;

namespace Core
{
    public interface IPathFinder
    {
        IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable, INeighborhood neighborGenerator);
    }
}
