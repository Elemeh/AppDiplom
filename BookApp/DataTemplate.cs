using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace BookApp
{
    public partial class DataTemplate
    {
        public DataTemplate()
        {
            InitializeComponent();
        }

        public void ButtonLink_Click(object sender, RoutedEventHandler e)
        {
            Button button = (Button)sender;
            //Frame.Navigate(typeof(AboutPage));
            button.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        }
    }

}
