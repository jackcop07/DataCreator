using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class DateService
    {
        private Random _rand;

        public DateService()
        {
            _rand = new Random();
        }


        public DateTime GetDate()
        {
            DateTime start = new DateTime(1922, 1, 1);
            int range = (DateTime.Now - start).Days;

            return start.AddDays(_rand.Next(range));
        }
    }
}
