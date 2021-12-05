using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants
{
    public class Card
    {
        public int Id { get; }
        public string Name { get; }
        public Unit CostType { get; }
        public int Cost { get; }
        public CardEffect[] Effects { get; }
        public bool Available { get; set; }

        public Card(int id, string name, Unit costType, int cost, CardEffect[] effects)
        {
            Id = id;
            Name = name;
            CostType = costType;
            Cost = cost;
            Effects = effects;
            Available = false;
        }

    }
}
