using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
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

            this.PopulateMainImageGrid();

            header.Bibliotek_clicked += new EventHandler(NavigateToLibrary);
        }

        private void PopulateMainImageGrid()
        {
            for (int i = 0; i < 10; i++)
            {
                var rowDef = new RowDefinition();
                rowDef.Height = new GridLength(150);
                MainImageGrid.RowDefinitions.Add(rowDef);
                MainImageGrid.ColumnDefinitions.Add(new ColumnDefinition());
                for (int j = 0; j < 10; j++)
                {
                    var image = MainPageImageHandler.CreateImageButtons(new Uri("ms-appx:///Assets/120px-Human_Thumbnail.jpg"));
                    MainImageGrid.Children.Add(image);
                    Grid.SetRow(image, i);
                    Grid.SetColumn(image, j);

                }
            }
        }

        

        public void NavigateToLibrary(object sender, EventArgs e)
        {
            Edit.Visibility = Visibility.Collapsed;
            ContentScrollViewer.Visibility = Visibility.Visible;
        }
    }
}
