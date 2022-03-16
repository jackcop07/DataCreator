namespace DataCreator.Library.Services
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
