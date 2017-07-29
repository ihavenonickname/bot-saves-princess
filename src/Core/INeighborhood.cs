using System.Collections.Generic;

namespace Core
{
    public interface INeighborhood
    {
        IEnumerable<Position> Neighbors(Position pos);
    }
}
