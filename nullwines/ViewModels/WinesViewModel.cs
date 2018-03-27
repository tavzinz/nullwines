using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Newtonsoft.Json;
using nullwines.Models;

namespace nullwines.ViewModels
{
    public class WinesViewModel : BaseViewModel
    {

        private ObservableCollection<Wine> _wines;
        public ObservableCollection<Wine> Wines
        {
            get { return _wines ?? (_wines = new ObservableCollection<Wine>()); }
            set
            {
                if (_wines != value)
                {
                    _wines = value;
                    OnPropertyChanged();
                }
            }
        }

        Wine _selectedWine;
        public Wine SelectedWine
        {
            get
            {
                return _selectedWine;
            }

            set
            {
                _selectedWine = value;

            }
        }

        public async void LoadItems()
        {
            var wines = await App.WineManager.GetWines();
            foreach (var wine in wines)
            {
                Wines.Add(wine);
            }
        }




    }
}
