using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio04
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {

            var stack = new StackLayout();


            var bnt1 = new Button();
            bnt1.Text = "Ejemplo 01";
            bnt1.Clicked += btn01;


            stack.Children.Add(bnt1);


            Content = stack;

        }

        async private void btn01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextToSpeechDemo());
        }
    }
}
