using GalgjeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Galgje.ViewModel
{
    public class MyViewModel : INotifyPropertyChanged
    {

        #region Comments / Todo
        // public int MoeilijkheidsGraad { get; set; }
        // public string Categorie { get; set; } 
        #endregion
        private GalgjeSpel spel;

        public GalgjeSpel Spel
        {
            get { return spel; }
            set
            {
                spel = value;
                RaisePropertyChanged("Spel");
            }
        }
        public MyViewModel()
        {
            Spel = new GalgjeSpel(); //geef evt moeilijkheidsgraad en categorie mee
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
