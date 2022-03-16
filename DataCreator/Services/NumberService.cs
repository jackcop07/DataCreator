using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class NumberService
    {
        private Random _random;
        private static int _id = 1;

        public NumberService()
        {
            _random = new Random();
        }

        public int GetAge()
        {
            return _random.Next(1, 90);
        }

        public int GetId()
        {
            return _id++;
        }
    }
}
