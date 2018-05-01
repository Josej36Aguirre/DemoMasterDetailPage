using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoMasterDetailPage
{
    public class NombreModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string nombre="") {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
            
        }
        private string nombre;

        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }
        }

    }
}
