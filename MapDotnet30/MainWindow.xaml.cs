using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = model;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            model.MyContent++;

            
        }
    }
}
