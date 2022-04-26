using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace NotesApp.BaseModel
{
    /// <summary>
    /// Interaction logic for WindowNotes.xaml
    /// </summary>
    public partial class WindowNotes : Window
    {
        public WindowNotes()
        {
            InitializeComponent();
            if (MainWindow.selectEntites != null)
            {
                tbTitle.Text = MainWindow.selectEntites.Title;
                tbBody.Text = MainWindow.selectEntites.Body;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
