using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12
{
    public static class ListExtension
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this List<T> list)
        {
            int sizeOfList = list.Count;

            while (sizeOfList > 1)
            {
                sizeOfList--;
                int randomNumber = rng.Next(sizeOfList + 1);
                T buffer = list[randomNumber];
                list[randomNumber] = list[sizeOfList];
                list[sizeOfList] = buffer;
            }
        }
    }
}
