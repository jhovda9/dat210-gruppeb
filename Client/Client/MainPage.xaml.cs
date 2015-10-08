using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Client
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Main.RowDefinitions.Add(new RowDefinition());
                Main.ColumnDefinitions.Add(new ColumnDefinition());
                for (int j = 0; j < 10; j++)
                {
                    var bildet = new Image();
                    bildet.Source = new BitmapImage(new Uri("ms-appx:///Assets/120px-Human_Thumbnail.jpg"));
                    bildet.Margin = new Thickness(2, 2, 2, 2);
                    Main.Children.Add(bildet);
                    Grid.SetRow(bildet, i);
                    Grid.SetColumn(bildet, j);

                }
            }
        }

        private void Content_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ContentScrollViewer.Height = e.NewSize.Height;
        }
    }
}
