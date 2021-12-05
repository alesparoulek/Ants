using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ants
{
    public class Bot : Player
    {
        public Bot(string name, int[] unitValues, Card[] cards) : base(name, unitValues, cards)
        {
        }

        public override int ChooseCard(ref bool discard)
        {
            List<int> availableCards = new List<int>();
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].Available) availableCards.Add(i);
            }
            discard = availableCards.Count == 0;
            Random rnd = new Random();
            int index = discard ? rnd.Next(cards.Length) : availableCards[rnd.Next(availableCards.Count)];
            return index;
        }
    }
}
