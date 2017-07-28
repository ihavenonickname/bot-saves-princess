using System.Collections.Generic;

namespace BotSavesPrincess_Core
{
    public interface INeighborhood
    {
        IEnumerable<Position> Neighbors(Position pos);
    }
}
