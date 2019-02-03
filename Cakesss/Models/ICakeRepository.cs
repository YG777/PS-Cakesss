using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cakesss.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> Cakes { get; }
        IEnumerable<Cake> CakesOfTheWeek { get; }

        Cake GetCakeById(int cakeId);
    }
}
