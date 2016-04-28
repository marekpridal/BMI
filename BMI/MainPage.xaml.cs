using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Globalization;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BMI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float vaha, vyska, vypocet;

            if((float.TryParse(textBox1.Text, out vaha))&&(float.TryParse(textBox2.Text,out vyska)))
            {
                vyska = vyska / 100;
                vypocet = ((vaha) / (vyska*vyska));
                if(vypocet<=16.5)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.DeepSkyBlue);
                    textBlock1.Text = "Váš BMI =" + vypocet.ToString() + ", trpíte těžkou podvýživou";
                }else if(vypocet<=18.5)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.SkyBlue);
                    textBlock1.Text = "Váš BMI =" + vypocet.ToString() + ", trpíte podvýživou";
                }else if (vypocet <= 25)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                    textBlock1.Text = "Váš BMI = " + vypocet.ToString() + ", máte ideální váhu";
                }
                else if (vypocet <= 30)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.YellowGreen);
                    textBlock1.Text = "Váš BMI =" + vypocet.ToString() + ", trpíte nadváhou";
                }
                else if (vypocet <= 35)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.Orange);
                    textBlock1.Text = "Váš BMI =" + vypocet.ToString() + ", máte mírnou obezitu";
                }
                else if (vypocet <= 40)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
                    textBlock1.Text = "Váš BMI =" + vypocet.ToString() + ", máte střední obezitu";
                }
                else if (vypocet > 40)
                {
                    textBlock1.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                    textBlock1.Text = "Váš BMI =" + vypocet.ToString() + ", trpíte morbidní obezitou";
                }
            }
            else
            {
                //textBlock1.Text = "Zadej hodnoty";
            }
        }
    }
}
