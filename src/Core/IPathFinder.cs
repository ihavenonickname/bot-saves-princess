using System.Collections.Generic;

namespace BotSavesPrincess_Core
{
    public interface IPathFinder
    {
        IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable, INeighborhood neighborGenerator);
    }
}
