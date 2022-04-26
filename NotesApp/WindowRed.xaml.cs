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
            Note currentNote = new Note();
            if (tbTitle.Text != "" && tbTitle.LineCount < 50 && tbBody.Text != "")
            {
                currentNote.Title = tbTitle.Text;
                currentNote.Body = tbBody.Text;
                try
                {
                    MainWindow.bd.Notes.Load();
                    MainWindow.bd.Notes.Remove(MainWindow.selectEntites);
                    MainWindow.bd.Notes.Add(currentNote);
                    MainWindow.bd.SaveChanges();
                    MessageBox.Show("Заметка сохранена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
                
            else
            {
                MessageBox.Show("Длина заголовка превышает 50 символов или вы пытаетесь сохранить пустую заметку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
