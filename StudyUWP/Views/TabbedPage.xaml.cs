using System;

using StudyUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace StudyUWP.Views
{
    public sealed partial class TabbedPage : Page
    {
        private TabbedViewModel ViewModel => DataContext as TabbedViewModel;

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
