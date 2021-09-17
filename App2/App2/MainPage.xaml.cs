using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static AndroidX.Core.App.NotificationCompat.MessagingStyle;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        int cont;
       string message;
        Button button1;

        public MainPage()
        {
            InitializeComponent();
            cont = 0;
        }


            void Handle_Clicked(object sender, System.EventArgs e)
            {
                if (button1 == null)
                
                    button1=((Button)sender);
                
                cont++;
                message = "You click me " + cont + " times";
                button1.Text= string.Format(message,cont);
            }

            void Handle_Clicked_1(object sender, System.EventArgs e)
            {
                message = "Click me";
                if (button1 != null)
                {
                    button1.Text = message;
                cont = 0;
                }
            }

        }
    }

