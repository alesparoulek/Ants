using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants
{
    public class Player : IPlayer
    {
        public string Name { get; }
        private readonly int[] unitValues;
        protected Card[] cards;

        public Player(string name, int[] unitValues, Card[] cards)
        {
            Name = name;
            this.unitValues = unitValues;
            this.cards = cards;
        }

        public int GetUnitValue(Unit unit)
        {
            return unitValues[(int)unit];
        }

        public void SetUnitValue(Unit unit, int value)
        {
            int result = unitValues[(int)unit] += value;

            if (unit == Unit.Castle)
            {
                unitValues[(int)unit] = result;
            }
            else if (unit == Unit.Builders || unit == Unit.Soldiers || unit == Unit.Magicians)
            {
                unitValues[(int)unit] = (result < 1) ? 1 : result;
            }
            else
            {
                unitValues[(int)unit] = (result < 0) ? 0 : result;
                if (unit == Unit.Wall && result < 0)
                {
                    SetUnitValue(Unit.Castle, result);
                }
            }

        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public void SetCard(int index, Card card)
        {
            cards[index] = card;
        }

        public void CheckCardsAvailability()
        {
            foreach (var card in cards)
            {
                card.Available = GetUnitValue(card.CostType) >= card.Cost;
            }
        }

        public virtual int ChooseCard(ref bool discard)
        {
            return 0;
        }

        public bool PlayCard(int index, IPlayer enemy)
        {
            Card card = GetCard(index);
            if (!card.Available) return false;
            SetUnitValue(card.CostType, -card.Cost);

            if (card.Id == 17)
            {
                int bricks = enemy.GetUnitValue(Unit.Bricks);
                SetUnitValue(Unit.Bricks, bricks > 5 ? 5 : bricks);
                int weapons = enemy.GetUnitValue(Unit.Weapons);
                SetUnitValue(Unit.Weapons, weapons > 5 ? 5 : weapons);
                int crystals = enemy.GetUnitValue(Unit.Crystals);
                SetUnitValue(Unit.Crystals, crystals > 5 ? 5 : crystals);

                enemy.SetUnitValue(Unit.Bricks, -5);
                enemy.SetUnitValue(Unit.Weapons, -5);
                enemy.SetUnitValue(Unit.Crystals, -5);
                return true;
            }

            foreach (var effect in card.Effects)
            {
                (effect.OnEnemy ? enemy : this).SetUnitValue(effect.AffectedUnit, effect.Value);
            }
            return true;
        }

    }
}
