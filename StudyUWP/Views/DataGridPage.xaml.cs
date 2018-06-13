using System;

using StudyUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace StudyUWP.Views
{
    public sealed partial class DataGridPage : Page
    {
        private DataGridViewModel ViewModel => DataContext as DataGridViewModel;

        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public DataGridPage()
        {
            InitializeComponent();
        }
    }
}
