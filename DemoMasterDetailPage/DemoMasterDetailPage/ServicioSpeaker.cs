using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMasterDetailPage
{
    public class ServicioSpeaker
    {
        public void Hablar(string texto)
        {
            CrossTextToSpeech.Current.Speak(texto);
        }
    }
}
