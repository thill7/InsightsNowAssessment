using System;
using System.Collections.Generic;
using System.Linq;

namespace BingoRoom.Bingo75
{
    public class Card : IGame.ICard
    {
        public IReadOnlyCollection<int> Squares { get; }

        protected IDictionary<int, SquareStatus> SquareStatuses { get; }

        public int CountSquaresRemaining { get; protected set; }

        public Card()
        {
            // Populate squares with random numbers, unchecked:
            // 5 between 1 and 15,
            // 5 between 16 and 30,
            // 4 between 31 and 45,
            // 5 between 46 and 60,
            // 5 between 61 and 75
            Squares = new[]
                {
                    (1, 15, 5),
                    (16, 30, 5),
                    (31, 45, 4),
                    (46, 60, 5),
                    (61, 75, 5)
                }
                .SelectMany(GetRandomNumbers)
                .ToList();

            SquareStatuses = Squares.ToDictionary(n => n, n => SquareStatus.Unchecked);
            CountSquaresRemaining = Squares.Count;
        }

        /// <summary>
        /// Initializes a card with  the given numbers checked
        /// </summary>
        /// <param name="calledNumbers">Numbers to check</param>
        public Card(IEnumerable<int> calledNumbers) : this()
        {
            if (calledNumbers == null) return;

            foreach (var checkNumber in calledNumbers)
            {
                Check(checkNumber);
            }
        }

        private IEnumerable<int> GetRandomNumbers((int min, int max, int count) group)
        {
            return Enumerable.Range(group.min, group.max - group.min + 1) // List all numbers
                .OrderBy(g => Guid.NewGuid()) // Shuffle
                .Take(group.count); // Get count
        }

        public void Check(int number)
        {
            if (!Squares.Contains(number)) return;

            SquareStatuses[number] = SquareStatus.Checked;
            CountSquaresRemaining--;
        }

        public bool IsChecked(int number)
        {
            return SquareStatuses[number] == SquareStatus.Checked;
        }

        public enum SquareStatus
        {
            Checked,
            Unchecked
        }
    }
}