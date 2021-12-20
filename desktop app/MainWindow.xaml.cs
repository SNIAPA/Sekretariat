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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace desktop_app
{

    /// <summary>
    /// Interaction log ic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        School school;
        public class Tasks : ObservableCollection<Task>
        {
            // Creating the Tasks collection in this way enables data binding from XAML.
        }

        public MainWindow()
        {
            InitializeComponent();

            school = new School();

            student_list.ItemsSource = school.students;

            importButton.Click += ImportButton_Click;

            student_list.

        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(school.students.Count);
        }



    }
}
