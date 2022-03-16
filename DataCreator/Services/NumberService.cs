namespace DataCreator.Library.Services
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
