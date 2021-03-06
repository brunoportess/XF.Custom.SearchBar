﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Samples.ViewModels
{
    public class SearchPageSampleViewModel : BaseViewModel
    {
        public ICommand SearchCommand { get; set; }
        private readonly IEnumerable<string> _nomes;

        private string _TextSearch;
        public string TextSearch
        {
            get => _TextSearch;
            set
            {
                _TextSearch = value;
                OnPropertyChanged();
                Listar(value);
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


        public SearchPageSampleViewModel()
		{
            _nomes = new List<string>
            {
                "Bruno", "Jose", "Augusto", "Pereira", "Maria", "Joana", "Antonia", "Fernanda", "Lucia", "Pedro"
            };
            Lista = _nomes.ToList();
        }

        public void Listar(string obj = "")
        {
            Lista = this._lista;
            if (!string.IsNullOrEmpty(obj))
                Lista = this._lista.Where(d => d.ToLower().Contains(obj.ToLower())).ToList();
        }        
	}
}

