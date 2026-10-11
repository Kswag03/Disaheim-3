using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim1
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            if(amulet.Quality >= Amulet.Level.Low)
            {
                return 12.5;
            }

            else if(amulet.Quality <= Amulet.Level.Medium)
            {
                return 20.00;
            }

            else
            {
                return 27.5;
            }

        }
    }


}
