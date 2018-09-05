using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Test_GitHub
{
    class Combat : INotifyPropertyChanged

    {
        private string name;
        private string ort;


        #region Konstruktoren

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
                OnPropertyChanged("Name");

            }
        }
        public string Ort
        {
            get { return ort; }
            set
            {
                this.ort = value;
                OnPropertyChanged("Ort");
            }
        }
        #endregion



        public Combat(string name, string ort)
        {
            this.Name = name;
            this.Ort = ort;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
