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
using System.Linq;

namespace desktop_app
{

    public partial class MainWindow : Window
    {

        School school;

        private void updateDataGrid(School _school= null)
        {
            if(_school != null)
                school = _school;

            student_list_grid.ItemsSource = school.students;
            teacher_list_grid.ItemsSource = school.teachers;
            group_list_grid.ItemsSource   = school.groups;
        }

        public MainWindow()
        {
            InitializeComponent();

            updateDataGrid(new School());

            ImportButton.Click += ImportButton_Click;
            ExportButton.Click += ExportButton_Click;

            testButton.Click += TestButton_Click;
            ResetButton.Click += ResetButton_Click;

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            updateDataGrid();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            
            List<KeyValuePair<Guid,string>> mappedList = school.students.Select(x => new KeyValuePair<Guid, string>( x.id,x.first_name)).ToList();

            student_list_grid.ItemsSource = new ObservableCollection<School.Student>(school.students.Where(x => FilterModule.Filter(mappedList, 2, "hubert").Contains(x.id)).ToList());

                        
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            IEmodule.export(school);
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            updateDataGrid(school);
        }
    }
}
