using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class JournalPage : Page
    {
        readonly ObservableCollection<Journal> journals = new ObservableCollection<Journal>();
        public JournalPage()
        {
            this.InitializeComponent();
            this.Loaded += JournalPage_Loaded; ;
        }

        private void JournalPage_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                journals.Add(new Journal
                {
                    Title = "Тема "+(i+1),
                    Date = DateTime.Now.ToString("MM/dd/yyyy H:mm"),
                    Grad = "Оценка "+5,
                    Link = i.ToString()
                });
            }
        }

        private void ButtonLink_Click(object sender, RoutedEventHandler e) 
        {
            Button button = (Button)sender;
            //Frame.Navigate(typeof(AboutPage));
            button.Background = new SolidColorBrush(Color.FromArgb(255, 48, 179, 221));
        }
    }
}
