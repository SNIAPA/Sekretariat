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
    // TODO: editable hotkeys
    // TODO: create separate class for 

    public partial class MainWindow : Window
    {

        School school;

        private void updateDataGrid(School _school= null)
        {
            if(_school != null)
                school = _school;

            student_list_grid.ItemsSource = school.students.DefaultView;
            teacher_list_grid.ItemsSource = school.teachers.DefaultView;
            group_list_grid.ItemsSource = school.groups.DefaultView;
        }

        public MainWindow()
        {
            InitializeComponent();

            updateDataGrid(new School());

            ImportButton.Click += ImportButton_Click;
            ExportButton.Click += ExportButton_Click;

            testButton.Click += TestButton_Click;
            ResetButton.Click += ResetButton_Click;

            FilterHelpButton.Click += FilterHelpButton_Click;
            filterBox.KeyDown += filterBox_KeyDown;

        }

        private void FilterHelpButton_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://docs.microsoft.com/en-us/dotnet/api/system.data.datacolumn.expression";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            school.students.DefaultView.RowFilter = "";
        }

        private void filterBox_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("Test");
            if (e.Key == Key.Enter)
            {
                TestButton_Click(this, new RoutedEventArgs());
            }
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                school.students.DefaultView.RowFilter = filterBox.Text;
                LinearGradientBrush myBrush = new LinearGradientBrush();
                filterBox.Background = myBrush;
            }
            catch(System.Data.EvaluateException err)
            {
                LinearGradientBrush myBrush = new LinearGradientBrush();
                myBrush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
                filterBox.Background = myBrush;
            }
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
