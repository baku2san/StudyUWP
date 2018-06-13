using System;

using StudyUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace StudyUWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
