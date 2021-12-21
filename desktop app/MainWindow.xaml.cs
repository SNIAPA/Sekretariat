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
using System.ComponentModel;

namespace desktop_app
{

    public partial class MainWindow : Window
    {

        SchoolView schoolView = new SchoolView();


        public MainWindow()
        {
            InitializeComponent();

            student_list_grid.ItemsSource = schoolView.students;
            teacher_list_grid.ItemsSource = schoolView.teachers;
            group_list_grid.ItemsSource = schoolView.groups;


            importButton.Click += ImportButton_Click;
            exportButton.Click += ExportButton_Click;
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            IEmodule.export(schoolView);
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            schoolView = IEmodule.import();
        }
    }
}
