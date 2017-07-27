using System.Collections.Generic;

namespace BotSavesPrincess
{
    interface IFinder
    {
        IEnumerable<Position> FindPath(Position start, Position target, HashSet<Position> nonReachable);

        IEnumerable<Position> FindPath(Position start, Position target);
    }
}
