using Acquario.ViewModels;
using System.Windows;

namespace Acquario.Views
{
    /// <summary>
    /// Logica di interazione per AcquarioView.xaml
    /// </summary>
    public partial class AcquarioView : Window
    {
        public AcquarioView()
        {
            InitializeComponent();
            if (this.DataContext is AcquarioViewModel acquarioViewModel)
            {
                acquarioViewModel.SetDispatcher(this.Dispatcher);
            }
        }
    }
}
