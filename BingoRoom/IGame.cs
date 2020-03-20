using System.Collections.Generic;

namespace BingoRoom
{
    public interface IGame
    {
        int CallBall();
        bool CallBingo(ICard card);
        ICard HandCard();
        void Restart();
        IEnumerable<int> CalledNumbers { get; }
        IReadOnlyCollection<ICard> Cards { get; }

        public interface ICard
        {
            IReadOnlyCollection<int> Squares { get; }
            public int CountSquaresRemaining { get; }
            void Check(int number);
            bool IsChecked(int number);
        }
    }
}