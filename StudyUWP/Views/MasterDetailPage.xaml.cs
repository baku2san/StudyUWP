using System;

using StudyUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace StudyUWP.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

        public MasterDetailPage()
        {
            InitializeComponent();
        }
    }
}
