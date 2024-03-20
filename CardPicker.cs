using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //Сгенерировать случайное число от 1 до 4 для выбора карточной масти
            int val = random.Next(1, 5);
            if (val == 1) return "Spades";
            if (val == 2) return "Hearts";
            if (val == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            //Сгенерировать случайное число от 1 до 13 для выбора номинала карты
            int val = random.Next(1, 14);
            if (val == 1) return "Ace";
            if (val == 11) return "Jack";
            if (val == 12) return "Queen";
            if (val == 13) return "King";
            return val.ToString();
        }
    }
}
