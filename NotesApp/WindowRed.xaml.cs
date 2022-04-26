using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NotesApp
{
    /// <summary>
    /// Interaction logic for WindowRed.xaml
    /// </summary>
    public partial class WindowRed : Window
    {
        public WindowRed()
        {
            InitializeComponent();
            tbTitle.Text = MainWindow.selectEntites.Title;
            tbBody.Text = MainWindow.selectEntites.Body;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
