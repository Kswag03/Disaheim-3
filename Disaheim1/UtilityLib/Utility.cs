using System;
using System.Collections.Generic;
using System.Text;
using Disaheim1;

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
            if(amulet.Quality == Level.Low)
            {
                return 12.5;
            }

            else if(amulet.Quality == Level.Medium)
            {
                return 20.00;
            }

            else
            {
                return 27.5;
            }

        }

        public double GetValueOfCourse(Course course)
        {
            if (course == null) return 0.0;

            int hours = course.DurationInMinutes / 60;
            if (course.DurationInMinutes % 60 != 0)
            {
                hours++;
            }
            return hours * 875.0;

        }
    }


}
