using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
//using System.Windows.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NotificationAPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        LinkedList<String> quotes = new LinkedList<String>();
        Random rando = new Random();

        public MainPage()
        {
            this.InitializeComponent();
            this.quotes.AddLast("Sharks don't even observe shark week");
            this.quotes.AddLast("#sixseasonsandamovie");
            this.quotes.AddLast("#anniesmove");
            this.quotes.AddLast("No, come back! Let's be fat dogs about this!");
            this.quotes.AddLast("Once you reach level 16, you can see the color blurple");
            this.quotes.AddLast("Troy and Abed in the morning!");
            this.quotes.AddLast("Troy and Abed in stop-motion!");
            this.quotes.AddLast("Donde esta la biblioteca? Me llama T-Bone, la arana discoteca.");
            this.quotes.AddLast("Discoteca, muneca, la biblioteca, es en la bigote grande, perro, manteca.");
            this.quotes.AddLast("Manteca, bigote, gigante, pequena, cabeza es mi helada. Cerveza es bueno!");
            this.quotes.AddLast("Buenas Dias! Me gusta papas frias! La bigote de la cabra es Cameron Diaz.");
            this.quotes.AddLast("Troy and Abed being normal.");
            this.quotes.AddLast("Troy and Abed sewn together!");
            this.quotes.AddLast("Troy and Abed shooting lava!");
            this.quotes.AddLast("Troy and Abed are in mourning!");
        }

        private void New_Note_Click(object sender, RoutedEventArgs e)
        {

            if (Notification.Visibility != Visibility.Visible)
            {
                Notification.Visibility = Visibility.Visible;
                Notification_Blurb.Text = this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count));
            }
            else if (Notification2.Visibility != Visibility.Visible)
            {
                Notification2.Visibility = Visibility.Visible;
                Notification_Blurb2.Text = this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count));
            }
            else {
                Notification3.Visibility = Visibility.Visible;
                Notification_Blurb3.Text = this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count));
            }
        }

        private void xButton_Click(object sender, RoutedEventArgs e)
        {
            ((RelativePanel)((Button)sender).Parent).Visibility = Visibility.Collapsed;
        }
    }
}
