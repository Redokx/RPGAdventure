using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class HealingPotion : Item
    {
        //properties
        public int AmountToHeal { get; set; }

        //constructor with derived classes
        public HealingPotion(int id, string name, string namePlural,int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }

    }
}
