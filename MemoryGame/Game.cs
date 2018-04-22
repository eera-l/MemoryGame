using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Game
    {
        private int[] cardArray = new int[] {0, 0, 1, 1, 2, 2, 3, 3, 4 , 4, 5, 5, 6, 6, 7, 7, 8, 8};
        private Random rnd = new Random();

        public int[] CardArray
        {
            get { return cardArray; }
        }

        public void Shuffle()
        {
            cardArray = cardArray.OrderBy(x => rnd.Next()).ToArray();
        }

        public string ArrayToString()
        {
            string result = string.Empty;
            foreach (int number in cardArray)
            {
                result = result + number.ToString();
            }
            return result;
        }
    }
}
