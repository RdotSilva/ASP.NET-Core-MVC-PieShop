using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieStore.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        IEnumerable<Pie> FruitPies { get; }
        IEnumerable<Pie> CheeseCakes { get; }
        IEnumerable<Pie> SeasonalPies { get; }

        Pie GetPieById(int pieId);
    }
}
