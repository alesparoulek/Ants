using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants
{
    public static class CardDeck
    {
        private static readonly List<Card> cards = new List<Card> {
            new Card(0, "Zeď", Unit.Bricks, 1, new CardEffect[]
            {
                new CardEffect(false, Unit.Wall, 3)
            }),
            new Card(1, "Základy", Unit.Bricks, 1, new CardEffect[]
            {
                new CardEffect(false, Unit.Castle, 2)
            }),
            new Card(2, "Obrana", Unit.Bricks, 3, new CardEffect[]
            {
                new CardEffect(false, Unit.Wall, 6)
            }),
            new Card(3, "Rezervy", Unit.Bricks, 3, new CardEffect[]
            {
                new CardEffect(false, Unit.Wall, -4),
                new CardEffect(false, Unit.Castle, 8)
            }),
            new Card(4, "Věž", Unit.Bricks, 5, new CardEffect[]
            {
                new CardEffect(false, Unit.Castle, 5)
            }),
            new Card(5, "Škola", Unit.Bricks, 8, new CardEffect[]
            {
                new CardEffect(false, Unit.Builders, 1)
            }),
            new Card(6, "Povoz", Unit.Bricks, 10, new CardEffect[]
            {
                new CardEffect(false, Unit.Castle, 8),
                new CardEffect(true, Unit.Castle, -4)
            }),
            new Card(7, "Hradba", Unit.Bricks, 12, new CardEffect[]
            {
                new CardEffect(false, Unit.Wall, 22)
            }),
            new Card(8, "Pevnost", Unit.Bricks, 18, new CardEffect[]
            {
                new CardEffect(false, Unit.Castle, 20)
            }),
            new Card(9, "Babylon", Unit.Bricks, 39, new CardEffect[]
            {
                new CardEffect(false, Unit.Castle, 32)
            }),
            new Card(10, "Střelec", Unit.Weapons, 1, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -2)
            }),
            new Card(11, "Rytíř", Unit.Weapons, 2, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -3)
            }),
            new Card(12, "Jezdec", Unit.Weapons, 2, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -4)
            }),
            new Card(13, "Četa", Unit.Weapons, 4, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -6)
            }),
            new Card(14, "Nábor", Unit.Weapons, 8, new CardEffect[]
            {
                new CardEffect(false, Unit.Soldiers, 1)
            }),
            new Card(15, "Zteč", Unit.Weapons, 10, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -12)
            }),
            new Card(16, "Sabotér", Unit.Weapons, 12, new CardEffect[]
            {
                new CardEffect(true, Unit.Bricks, -4),
                new CardEffect(true, Unit.Weapons, -4),
                new CardEffect(true, Unit.Crystals, -4)
            }),
            new Card(17, "Zloděj", Unit.Weapons, 15, new CardEffect[]
            {
                new CardEffect(true, Unit.Bricks, -5),
                new CardEffect(true, Unit.Weapons, -5),
                new CardEffect(true, Unit.Crystals, -5),
                new CardEffect(false, Unit.Bricks, 5),
                new CardEffect(false, Unit.Weapons, 5),
                new CardEffect(false, Unit.Crystals, 5)
            }),
            new Card(18, "SWAT", Unit.Weapons, 18, new CardEffect[]
            {
                new CardEffect(true, Unit.Castle, -10)
            }),
            new Card(19, "Smrtka", Unit.Weapons, 28, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -32)
            }),
            new Card(20, "Čaruj cihly", Unit.Crystals, 4, new CardEffect[]
            {
                new CardEffect(false, Unit.Bricks, 8)
            }),
            new Card(21, "Čaruj krystaly", Unit.Crystals, 4, new CardEffect[]
            {
                new CardEffect(false, Unit.Crystals, 8)
            }),
            new Card(22, "Čaruj zbraně", Unit.Crystals, 4, new CardEffect[]
            {
                new CardEffect(false, Unit.Weapons, 8)
            }),
            new Card(23, "Znič cihly", Unit.Crystals, 4, new CardEffect[]
            {
                new CardEffect(true, Unit.Bricks, -8)
            }),
            new Card(24, "Znič krystaly", Unit.Crystals, 4, new CardEffect[]
            {
                new CardEffect(true, Unit.Crystals, -8)
            }),
            new Card(25, "Znič zbraně", Unit.Crystals, 4, new CardEffect[]
            {
                new CardEffect(true, Unit.Weapons, -8)
            }),
            new Card(26, "Čaroděj", Unit.Crystals, 8, new CardEffect[]
            {
                new CardEffect(false, Unit.Magicians, 1)
            }),
            new Card(27, "Drak", Unit.Crystals, 21, new CardEffect[]
            {
                new CardEffect(true, Unit.Wall, -25)
            }),
            new Card(28, "Skřítci", Unit.Crystals, 22, new CardEffect[]
            {
                new CardEffect(false, Unit.Castle, 22)
            }),
            new Card(29, "Kletba", Unit.Crystals, 25, new CardEffect[]
            {
                new CardEffect(true, Unit.Builders, -1),
                new CardEffect(true, Unit.Bricks, -1),
                new CardEffect(true, Unit.Soldiers, -1),
                new CardEffect(true, Unit.Weapons, -1),
                new CardEffect(true, Unit.Magicians, -1),
                new CardEffect(true, Unit.Crystals, -1),
                new CardEffect(true, Unit.Castle, -1),
                new CardEffect(true, Unit.Wall, -1),
                new CardEffect(false, Unit.Builders, 1),
                new CardEffect(false, Unit.Bricks, 1),
                new CardEffect(false, Unit.Soldiers, 1),
                new CardEffect(false, Unit.Weapons, 1),
                new CardEffect(false, Unit.Magicians, 1),
                new CardEffect(false, Unit.Crystals, 1),
                new CardEffect(false, Unit.Castle, 1),
                new CardEffect(false, Unit.Wall, 1)
         })};

        public static int Size => cards.Count;

        public static Card GetCard(int id)
        {
            return cards[id];
        }

    }
}
