using DataCreator.Helpers;
using DataCreator.Models;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
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
                _names = fileHelperEngine.ReadFile(@"names.csv").ToList();
            }

            int index = _random.Next(0, _names.Count() - 1);

            return StringHelper.FormatName(_names[index].Name);
        }

        public string GetLastName()
        {
            if (!_names.Any())
            {
                var fileHelperEngine = new FileHelperEngine<NameModel>();
                _names = fileHelperEngine.ReadFile(@"surnames.csv").ToList();
            }

            int index = _random.Next(0, _names.Count() - 1);

            return StringHelper.FormatName(_names[index].Name);
        }
    }
}
