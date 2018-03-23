using System.Diagnostics;
using System.Net.Http;
using System.Windows.Input;
using Xamarin.Forms;

namespace Samples.ViewModels
{
	public class SearchPageSampleViewModel : BaseViewModel
	{
		public SearchPageSampleViewModel()
		{
			
		}

        public ICommand SearchCommand { get; set; }
        private string _TextSearch;
        public string TextSearch
        {
            get { return _TextSearch; }
            set {
                _TextSearch = value;
                OnPropertyChanged();
                Debug.WriteLine("SEARCH TEXT: " + value);
            }
        }
        string searchResult;

		public string SearchResult
		{
			get
			{
				return searchResult;
			}

			set
			{
				searchResult = value;
				OnPropertyChanged();
			}
		}
	}
}

