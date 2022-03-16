using DataCreator.Library.Models;
using FileHelpers;

namespace DataCreator.Library.Repositories
{
    public class NameRepository
    {
        private List<NameModel> _names = new List<NameModel>();
        private Random _random;

        public NameRepository()
        {
            _random = new Random();
        }


        public string GetFirstName()
        {
            if (!_names.Any())
            {
                var fileHelperEngine = new FileHelperEngine<NameModel>();
                _names = fileHelperEngine.ReadFile(@"Data\names.csv").ToList();
            }

            int index = _random.Next(0, _names.Count() - 1);

            return _names[index].Name;
        }

        public string GetLastName()
        {
            if (!_names.Any())
            {
                var fileHelperEngine = new FileHelperEngine<NameModel>();
                _names = fileHelperEngine.ReadFile(@"Data\surnames.csv").ToList();
            }

            int index = _random.Next(0, _names.Count() - 1);

            return _names[index].Name;
        }
    }
}
