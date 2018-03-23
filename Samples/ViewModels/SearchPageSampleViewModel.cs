using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Forms;

namespace Samples.ViewModels
{
	public class SearchPageSampleViewModel : BaseViewModel
	{
        public ICommand SearchCommand { get; set; }

        private string _TextSearch;
        public string TextSearch
        {
            get => _TextSearch;
            set
            {
                _TextSearch = value;
                OnPropertyChanged();
                FiltraLista(value);
                //Debug.WriteLine("SEARCH TEXT: " + value);
            }
        }

        private List<string> _lista;
        public List<string> Lista
        {
            get { return _lista; }
            set {
                _lista = value;
                OnPropertyChanged();
            }
        }

        private List<string> _dados;
        public List<string> Dados
        {
            get { return _dados; }
            set
            {
                _dados = value;
                OnPropertyChanged();
            }
        }

        public SearchPageSampleViewModel()
		{
            Dados = new List<string>
            {
                "Bruno", "Jose", "Augusto", "Pereira", "Maria", "Joana", "Antonia", "Fernanda", "Lucia", "Pedro"
            };
            Lista = Dados;
        }

        public void FiltraLista(string obj = "")
        {
            

            if (string.IsNullOrEmpty(obj))
            {
                Lista = Dados;
            }
            else
            {
                Lista = Dados.Where(d => d.ToLower().Contains(obj.ToLower())).ToList();
            }
        }        
	}
}

