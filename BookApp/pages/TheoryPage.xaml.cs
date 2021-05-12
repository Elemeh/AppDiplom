using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace BookApp
{
    public sealed partial class TheoryPage : Page
    {

        readonly ObservableCollection<NavLinks> navLinks = new ObservableCollection<NavLinks>();
        public TheoryPage()
        {
            this.InitializeComponent();
            this.Loaded += TheoryPage_Loaded;
        }

        private void TheoryPage_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                navLinks.Add(new NavLinks
                {
                    Title = (i + 1) + "    Тема. Теория",
                });
            }
        }

        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            TheorySplitView.IsPaneOpen = !TheorySplitView.IsPaneOpen; 
        }
    }
}
