using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        //properties
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        //construtor
        public LivingCreature(int currentHitPoints, int maximuxHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximuxHitPoints;
        }
    }
}
