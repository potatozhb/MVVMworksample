using Model;
using System.Windows;

namespace MVVMworksample
{
    /// <summary>
    /// Interaction logic for UpdateWin.xaml
    /// </summary>
    public partial class UpdateWin : Window
    {
        public UpdateWin()
        {
            InitializeComponent();
            this.DataContext = new Users();
        }
    }
}
