using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Galeri
{
    public partial class MainPage : CarouselPage
    {
        int imagen1;
        int imagen1n;
        int imagen2;
        int imagen2n;
        int imagen3;
        int imagen3n;
        int imagen4;
        int imagen4n;
        int imagen5;
        int imagen5n;
        int imagen6;
        int imagen6n;
        int imagen7;
        int imagen7n;
        int imagen8;
        int imagen8n;
        int imagen9;
        int imagen9n;
        int imagen10;
        int imagen10n;
        int resultado;

        public MainPage()
        {
            InitializeComponent();
        }


        private void MabelS_Clicked(object sender, EventArgs e)
        {
            
                imagen1 = 1;
                if (imagen1 == 1)
                {
                    resultado = resultado + 1;
         
                
            }
        }

        private void MabelN_Clicked(object sender, EventArgs e)
        {
            
            imagen1n = 0;
            if (imagen1n == 0)
            {
                resultado = resultado + 0;
                   
            
        }
        }

        private void Im2S_Clicked(object sender, EventArgs e)
        {
            
            imagen2 = 1;
            if (imagen2 == 1)
            {
                resultado = resultado + 1;
            }
        }

        private void Im2N_Clicked(object sender, EventArgs e)
        {
            imagen2n = 0;
            if (imagen2n == 0)
            {
                resultado = resultado + 0;
            }
        }
        private void Im3S_Clicked(object sender, EventArgs e)
        {
            imagen3 = 1;
            if (imagen3 == 1)
            {
                resultado = resultado + 1;
            }
        }

        private void Im3N_Clicked(object sender, EventArgs e)
        {
            imagen3n = 0;
            if (imagen3n == 0)
            {
                resultado = resultado + 0;
            }
        }

        private void Im4S_Clicked(object sender, EventArgs e)
        {
            imagen4 = 1;
            if (imagen4 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im4N_Clicked(object sender, EventArgs e)
        {
            imagen4n = 0;
            if (imagen4n == 0)
            {
                resultado = resultado + 0;
            }
        }
        private void Im5S_Clicked(object sender, EventArgs e)
        {
            imagen5 = 1;
            if (imagen5 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im5N_Clicked(object sender, EventArgs e)
        {
            imagen5n = 0;
            if (imagen5n == 0)
            {
                resultado = resultado + 0;
            }

        }

        private void Im6S_Clicked(object sender, EventArgs e)
        {
            imagen6 = 1;
            if (imagen6 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im6N_Clicked(object sender, EventArgs e)
        {
            imagen6n = 0;
            if (imagen6n == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void Im7S_Clicked(object sender, EventArgs e)
        {
            imagen7 = 1;
            if (imagen7 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im7N_Clicked(object sender, EventArgs e)
        {
            imagen7n = 0;
            if (imagen7n == 0)
            {
                resultado = resultado + 0;
            }
        }
        private void Im8S_Clicked(object sender, EventArgs e)
        {
            imagen8 = 1;
            if (imagen8 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im8N_Clicked(object sender, EventArgs e)
        {
            imagen8n = 0;
            if (imagen8n == 0)
            {
                resultado = resultado + 0;
            }
        }
        private void Im9S_Clicked(object sender, EventArgs e)
        {
            imagen9 = 1;
            if (imagen9 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im9N_Clicked(object sender, EventArgs e)
        {
            imagen9n = 0;
            if (imagen9n == 0)
            {
                resultado = resultado + 0;
            }

        }
        private void Im10S_Clicked(object sender, EventArgs e)
        {
            imagen10 = 1;
            if (imagen10 == 1)
            {
                resultado = resultado + 1;
            }
        }
        private void Im10N_Clicked(object sender, EventArgs e)
        {
            imagen10n = 0;
            if (imagen10n == 0)
            {
                resultado = resultado + 0;
            }
        }

        private void Evaluar_Clicked(object sender, EventArgs e)
        {
            if (imagen1 == 1)
            {
                DisplayAlert("", "Imagen 1 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 1 Sin dato", "OK");
            }


            if (imagen2 == 1)
            {
                DisplayAlert("", "Imagen 2 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 2 Sin dato", "OK");
            }

            if (imagen3 == 1)
            {
                DisplayAlert("", "Imagen 3 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 3 Sin dato", "OK");
            }
            if (imagen4 == 1)
            {
                DisplayAlert("", "Imagen 4 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 4 Sin dato", "OK");
            }
            if (imagen5 == 1)
            {
                DisplayAlert("", "Imagen 5 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 5 Sin dato", "OK");
            }
            if (imagen6 == 1)
            {
                DisplayAlert("", "Imagen 6 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 6 Sin dato", "OK");
            }
            if (imagen7 == 1)
            {
                DisplayAlert("", "Imagen 7 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 7 Sin dato", "OK");
            }
            if (imagen8 == 1)
            {
                DisplayAlert("", "Imagen 8 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 8 Sin dato", "OK");
            }
            if (imagen9 == 1)
            {
                DisplayAlert("", "Imagen 9 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 9 Sin dato", "OK");
            }
            if (imagen10 == 1)
            {
                DisplayAlert("", "Imagen 10 Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 10 Sin dato", "OK");
            }

        }

        private void EvaluarDL_Clicked(object sender, EventArgs e)
        {
            if (imagen1n == 0)
            {
                DisplayAlert("", "Imagen 1 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 1 Sin dato", "OK");
            }

            if (imagen2n == 0)
            {
                DisplayAlert("", "Imagen 2 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 2 Sin dato", "OK");
            }

            if (imagen3n == 0)
            {
                DisplayAlert("", "Imagen 3 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 3 Sin dato", "OK");
            }

            if (imagen4n == 0)
            {
                DisplayAlert("", "Imagen 4 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 4 Sin dato", "OK");
            }

            if (imagen5n == 0)
            {
                DisplayAlert("", "Imagen 5 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 5 Sin dato", "OK");
            }

            if (imagen6n == 0)
            {
                DisplayAlert("", "Imagen 6 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 6 Sin dato", "OK");
            }

            if (imagen7n == 0)
            {
                DisplayAlert("", "Imagen 7 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 7 Sin dato", "OK");
            }

            if (imagen8n == 0)
            {
                DisplayAlert("", "Imagen 8 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 9 Sin dato", "OK");
            }

            if (imagen9n == 0)
            {
                DisplayAlert("", "Imagen 9 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 9 Sin dato", "OK");
            }

            if (imagen10n == 0)
            {
                DisplayAlert("", "Imagen 10 No Me Gusta", "OK");
            }
            else
            {
                DisplayAlert("", "Imagen 10 Sin dato", "OK");
            }


        }



    }
}
