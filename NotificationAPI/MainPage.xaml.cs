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

        private async void New_Note_Click(object sender, RoutedEventArgs e)
        {
            RelativePanel rPan = new RelativePanel();
            Button dButton = new Button();
            //Height = "86" Width = "340" Margin = "10,544,0,0"
            dButton.Height = 86;
            dButton.Width = 340;
            //dButton.Margin = "10,544,0,0";
            dButton.Content = "X";

            rPan.Children.Add(dButton);
            rPan.Visibility = Visibility.Visible;
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

        private async void tapNotification(object sender, TappedRoutedEventArgs e) {
            //RelativePanel collapseMe = ;
            ((RelativePanel)sender).Visibility = Visibility.Collapsed;
        }

    }
}
