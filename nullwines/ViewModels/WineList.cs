using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Newtonsoft.Json;
using nullwines.Models;

namespace nullwines.ViewModels
{
    public class WineList
    {
        public WineList()
        {
            GetWines();
        }



        public ObservableCollection<Wine> Wines
        {
            get;
            set;
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

        private async void GetWines()
        {
            await App.WineManager.GetWines();
        }




    }
}
