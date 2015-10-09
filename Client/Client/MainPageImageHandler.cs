using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace Client
{
    class MainPageImageHandler
    {
        public static Button CreateImageButtons(Uri source)
        {
            var button = new Button();
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(source);
            button.Background = brush;
            button.Margin = new Thickness(2, 2, 2, 2);
            button.HorizontalAlignment = HorizontalAlignment.Stretch;
            button.VerticalAlignment = VerticalAlignment.Stretch;
            button.Name = "thumbnail";

            var flyout = DisplayFullSizeImage();
            button.Flyout = flyout;
            return button;
        }

        public static Flyout DisplayFullSizeImage()
        {
            var flyout = new Flyout();
            var image = new Image();
            image.Source = new BitmapImage(new Uri("ms-appx:///Assets/120px-Human_Thumbnail.jpg"));
            flyout.Content = image;
            flyout.Placement = FlyoutPlacementMode.Full;
            return flyout;
        }
    }
}
