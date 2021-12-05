using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants
{
    public class CardEffect
    {
        public bool OnEnemy { get; }
        public Unit AffectedUnit { get; }
        public int Value { get; }

        public CardEffect(bool e, Unit u, int v)
        {
            OnEnemy = e;
            AffectedUnit = u;
            Value = v;
        }
    }
}
