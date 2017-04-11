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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void New_Note_Click(object sender, RoutedEventArgs e)
        {
            /*HorizontalAlignment = "Left" Height = "174" VerticalAlignment = "Top" 
             * Width = "327" BorderBrush = "#FF000000" BorderThickness = "5" 
             * Tapped = "tapNotification" Margin = "10,10,0,0" Background = "#FFDAD7D7"
            */

            if (Notification.Visibility != Visibility.Visible)
            {
                Notification.Visibility = Visibility.Visible;
                Notification_Blurb.Text = "#anniesmove";
            }
            else if (Notification2.Visibility != Visibility.Visible)
            {
                Notification2.Visibility = Visibility.Visible;
                Notification_Blurb2.Text = "Wubba lubba dub dub";
            }
            else {
                Notification3.Visibility = Visibility.Visible;
                Notification_Blurb3.Text = "And that's the way the news goes";
            }
            
            /*RelativePanel rPan = new RelativePanel();
            rPan.HorizontalAlignment = HorizontalAlignment.Left;
            rPan.Height = 174;
            rPan.VerticalAlignment = VerticalAlignment.Top;
            rPan.Width = 327;
            //rPan.BorderBrush = "#FF000000";
            rPan.SetValue(BorderBrushProperty, "#FF000000");
            //rPan.BorderThickness = 5;
            rPan.SetValue(BorderThicknessProperty, 5);
            rPan.Tapped += tapNotification;
            //rPan.Margin = 10;
            rPan.SetValue(MarginProperty, 10);
            //rPan.Background = "#FFDAD7D7";
            rPan.SetValue(BackgroundProperty, "#FFDAD7D7");*/

            //Button dButton = new Button();
            //Height = "86" Width = "340" Margin = "10,544,0,0"
            //dButton.Height = 86;
            //dButton.Width = 340;
            //dButton.Margin = "10,544,0,0";
            //dButton.Content = "X";

            //rPan.Children.Add(dButton);
            
            //rPan.Visibility = Visibility.Visible;
            //var image = new Image();
            //image.Source = ...;
            //image.Stretch = Stretch.None;
            /*var listView = new ListView();
            var txt = new TextBlock();
            txt.Text = "Test 123";*/
            //label.Content = "Test 123";

            //DockPanel.SetDock(image, Dock.Left);
            //RelativePanel.SetValue(RelativePanel.AlignLeftWithProperty,txt);

            //var relativePanel = new RelativePanel();
            //relativePanel.Children.Add(image);
            //relativePanel.Children.Add(txt);
            //var item = new ListViewItem();
            //item.Content = relativePanel;

            //listView.Items.Add(item);
        }

        /*private async void tapNotification(object sender, TappedRoutedEventArgs e) {
            //RelativePanel collapseMe = ;
            ((RelativePanel)sender).Visibility = Visibility.Collapsed;
        }*/

        private void xButton_Click(object sender, RoutedEventArgs e)
        {
            ((RelativePanel)((Button)sender).Parent).Visibility = Visibility.Collapsed;
        }
    }
}
