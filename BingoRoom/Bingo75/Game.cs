using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoRoom.Bingo75
{
    public class Game : IGame
    {
        private readonly HashSet<int> _calledNumbers = new HashSet<int>();
        private IList<int> _availableNumbers;
        private readonly Random _random = new Random();
        private readonly List<Card> _cards = new List<Card>();
        public IEnumerable<int> CalledNumbers => _calledNumbers;

        public IReadOnlyCollection<IGame.ICard> Cards => _cards;

        public Game()
        {
            Restart();
        }

        public void Restart()
        {
            _calledNumbers.Clear();
            _availableNumbers = Enumerable.Range(1, 75).ToList();
            _cards.Clear();
        }

        /// <summary>
        /// Call Bingo
        /// </summary>
        /// <remarks>
        /// If the card is not right, the card is removed
        /// </remarks>
        /// <param name="card">The card for which the bingo was called</param>
        /// <returns>If the bingo was called successfully</returns>
        public bool CallBingo(IGame.ICard card)
        {
            if (!(card is Card myCard)) return false;
            if (!_cards.Contains(myCard)) return false;

            // Validate
            var valid = _calledNumbers.All(n => card.Squares.Contains(n));
            if (valid)
            {
                // Bingo!
                Restart();
            }
            else
            {
                _cards.Remove((Card)card);
                // Game continues
            }

            return valid;
        }

        /// <summary>
        /// Pop a random available number and return it
        /// </summary>
        /// <returns>The number called</returns>
        public int CallBall()
        {
            if (!_availableNumbers.Any())
                throw new InvalidOperationException("No balls left");

            var index = _random.Next(_availableNumbers.Count);
            var number = _availableNumbers[index];

            _availableNumbers.Remove(number);
            _calledNumbers.Add(number);

            return number;
        }
        
        /// <summary>
        /// Teller hands a new card to a client
        /// </summary>
        /// <remarks>
        /// The card has checked the numbers called so far if it is during the game
        /// </remarks>
        /// <returns>The new card</returns>
        public IGame.ICard HandCard()
        {
            var card = new Card(_calledNumbers);
            _cards.Add(card);

            return card;
        }
    }
}
