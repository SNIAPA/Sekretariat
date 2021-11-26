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

        School school = new School();


        public MainWindow()
        {
            InitializeComponent();


            school.students.Add(new School.Student() {first_name = "adam"});

            dataGrid1.ItemsSource = school.students;
        }
        void delete(object sender, EventArgs e)
        {
            Debug.WriteLine(sender.ToString());
        }
    }
}
