using System;
using System.Collections.Generic;

namespace BotSavesPrincess
{
    interface INeighborGenerator
    {
        IEnumerable<Position> Neighborhood(Position pos);
    }
}
