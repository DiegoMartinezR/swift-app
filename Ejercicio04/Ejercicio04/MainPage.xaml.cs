﻿using System;
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


            var btn1 = new Button();
            btn1.Text = "Ejemplo 01";
            btn1.Clicked += btn01;

            var btn2 = new Button();
            btn2.Text = "Ejemplo 02";
            btn2.Clicked += btn02;

            
            stack.Children.Add(btn1);
            stack.Children.Add(btn2);
                

            Content = stack;

        }

        async private void btn02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BatteryDemo());
        }

        async private void btn01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextToSpeechDemo());
        }
    }
}
