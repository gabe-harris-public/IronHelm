using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelm
{
    public interface IBeing
    {
        int DamageModifier { get; set; }
        int Health { get; set; }
        int HealthMaximum { get; set; }
        string Name { get; }
        int Wealth { get; set; }
    }
}
