using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoMasterDetailPage
{
    public class NombreViewModel:NombreModel
    {
        public Command HablarCommand { get; set; }

        public NombreViewModel()
        {
            HablarCommand = new Command(DecirNombre);
        }
        private void DecirNombre()
        {
            new ServicioSpeaker().Hablar(Nombre);
        }
    }
}
