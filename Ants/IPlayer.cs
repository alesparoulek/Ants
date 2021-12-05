using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ants
{
    /// <summary>
    /// Represents a player.
    /// </summary>
    public interface IPlayer
    {
        string Name { get; }

        /// <summary>
        /// Gets the value of specified unit.
        /// </summary>
        /// <param name="unit">Unit</param>
        /// <returns>The value.</returns>
        int GetUnitValue(Unit unit);

        /// <summary>
        /// Updates a unit value by adding new value to it. The value can be negative.
        /// </summary>
        /// <param name="unit">Unit</param>
        /// <param name="value">Value</param>
        void SetUnitValue(Unit unit, int value);

        /// <summary>
        /// Returns player's card on specified index. THIS LOOKS LIKE A DISCARD CARD FUNCTION
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Card on specified index.</returns>
        Card GetCard(int index);

        /// <summary>
        /// Puts new card into player's stack at index position.
        /// </summary>
        /// <param name="index">Index</param>
        /// <param name="card">Card</param>
        void SetCard(int index, Card card);

        /// <summary>
        /// Checks for which cards the player has enough resources to play them
        /// and sets the availability of the cards. 
        /// </summary>
        void CheckCardsAvailability();

        /// <summary>
        /// Chooses the card to be played.
        /// </summary>
        /// <param name="discard">Sets true if the card is discarded</param>
        /// <returns>index of the card to be played</returns>
        int ChooseCard(ref bool discard);

        /// <summary>
        /// Plays player's card.
        /// </summary>
        /// <param name="player">Current player</param>
        /// <param name="enemy">Second player</param>
        /// <param name="index">Index of current player's card</param>
        /// <returns>
        /// True if the card was played succesfully, false if the card isn't available for the player
        /// </returns>
        bool PlayCard(int index, IPlayer enemy);
    }
}
