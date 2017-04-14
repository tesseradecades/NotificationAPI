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
        LinkedList<RelativePanel> notes = new LinkedList<RelativePanel>();
        LinkedList<NoteData> newNotes = new LinkedList<NoteData>();

        private partial class NoteData {

            public String txt;
            public ImageSource img;
            public String blurb;

            public NoteData(String t, ImageSource i, String b) {
                this.txt = t;
                this.img = i;
                this.blurb = b;
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
            this.notes.AddLast(Notification);
            this.notes.AddLast(Notification2);
            this.notes.AddLast(Notification3);
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

            for (int i = 0; i < this.notes.Count; i++)
            {
                RelativePanel r = this.notes.ElementAt<RelativePanel>(i);
                if (r.Visibility != Visibility.Visible)
                {
                    ((TextBlock)r.Children.ElementAt<UIElement>(0)).Text = this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count));
                    ((TextBlock)r.Children.ElementAt<UIElement>(2)).Text = this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count));
                    r.Visibility = Visibility.Visible;
                    break;
                }
            }
        }

        /*
        private void New_Note_Click(object sender, RoutedEventArgs e)
        {

            newNotes.AddLast(new NoteData(this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count)), image.Source, this.quotes.ElementAt<String>(rando.Next(0, this.quotes.Count) ) ) );

            this.updateNotes();
        }*/

        private void updateNotes() {
            int i = newNotes.Count;
            if (i > 0)
            {
                NoteData note1 = newNotes.ElementAt<NoteData>(0);
                //Notification1 stuff
                ((TextBlock)Notification.Children.ElementAt<UIElement>(0)).Text = note1.txt;
                ((Image)Notification.Children.ElementAt<UIElement>(1)).Source = note1.img;
                ((TextBlock)Notification.Children.ElementAt<UIElement>(2)).Text = note1.blurb;
                Notification.Visibility = Visibility.Visible;
            }
            if (i > 1)
            {
                NoteData note2 = newNotes.ElementAt<NoteData>(1);
                //Notification2 stuff
                ((TextBlock)Notification2.Children.ElementAt<UIElement>(0)).Text = note2.txt;
                ((Image)Notification2.Children.ElementAt<UIElement>(1)).Source = note2.img;
                ((TextBlock)Notification2.Children.ElementAt<UIElement>(2)).Text = note2.blurb;
                Notification2.Visibility = Visibility.Visible;
            }
            if (i > 2)
            {
                NoteData note3 = newNotes.ElementAt<NoteData>(2);
                //Notification1 stuff
                ((TextBlock)Notification3.Children.ElementAt<UIElement>(0)).Text = note3.txt;
                ((Image)Notification3.Children.ElementAt<UIElement>(1)).Source = note3.img;
                ((TextBlock)Notification3.Children.ElementAt<UIElement>(2)).Text = note3.blurb;
                Notification3.Visibility = Visibility.Visible;
            }
        }

        private void xButton_Click(object sender, RoutedEventArgs e)
        {
            RelativePanel r = ((RelativePanel)((Button)sender).Parent);
            //r.Visibility = Visibility.Collapsed;
            int ix = this.indexOf(this.notes, r);
            if (ix == 0)
            {
                textBlock.Text = textBlock2.Text;
                image.Source = image2.Source;
                Notification_Blurb.Text = Notification_Blurb2.Text;

                textBlock2.Text = textBlock3.Text;
                image2.Source = image3.Source;
                Notification_Blurb2.Text = Notification_Blurb3.Text;
            }
            else if (ix == 1)
            {
                textBlock2.Text = textBlock3.Text;
                image2.Source = image3.Source;
                Notification_Blurb2.Text = Notification_Blurb3.Text;

            }

            if (Notification3.Visibility == Visibility.Collapsed)
            {
                if (Notification2.Visibility == Visibility.Collapsed)
                {
                    Notification.Visibility = Visibility.Collapsed;
                }
                else
                {
                    Notification2.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                Notification3.Visibility = Visibility.Collapsed;
            }

        }

        /*
        private void xButton_Click(object sender, RoutedEventArgs e)
        {
            RelativePanel r = ((RelativePanel)((Button)sender).Parent);
            r.Visibility = Visibility.Collapsed;
            if ( r == Notification ) {
                this.newNotes.RemoveFirst();
            }
            else if ( r == Notification2 ) {
                this.newNotes.Remove(this.newNotes.ElementAt<NoteData>(1));
            }
            else if ( r == Notification3) {
                this.newNotes.Remove(this.newNotes.ElementAt<NoteData>(2));
            }

            this.updateNotes();
        }*/

        private int indexOf(LinkedList<RelativePanel> l, Object o) {
            for (int i = 0; i < l.Count; i++) {
                if (l.ElementAt<RelativePanel>(i) == o) {
                    return i;
                    break;
                }
            }
            return -1;
        }
    }
}
