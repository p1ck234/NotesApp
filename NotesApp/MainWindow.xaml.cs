using NotesApp.BaseModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static BaseModel.ModelBase bd = new BaseModel.ModelBase();
        public MainWindow()
        {
            InitializeComponent();
            bd.Notes.Load();
            lvNotes.ItemsSource = bd.Notes.Local;
        }

        public static Note selectEntites = new Note();
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNotes a = new WindowNotes();
            a.Show();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            bd.Notes.Load();
            selectEntites = (Note)lvNotes.SelectedItem;
            if (MessageBox.Show("Вы действительно хотите удалить эту заметку?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    bd.Notes.Remove(selectEntites);
                    bd.SaveChanges();
                    MessageBox.Show("Заметка удалена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            selectEntites = (Note)lvNotes.SelectedItem;
            if (selectEntites != null)
            {
                WindowRed a = new WindowRed();
                a.Show();
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
