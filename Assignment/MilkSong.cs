using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MilkSong
    {

      public string Lyric(int number)
        {
            string lyric = number+" bottles of milk on the wall, "+ number +" bottles of milk. Take one down and pass it around, \r\n";


              return lyric;
         }

        public void Song(int number)
        {
            while(number > 1)
            {
                number--;

                if (number == 1)
                {
                    Console.WriteLine("1 bottle of milk on the wall, 1 bottle of milk. Take it and drink it");
                }
                else
                {
                      Console.WriteLine(Lyric(number));
                    

                }
            }
        }
    }

}

