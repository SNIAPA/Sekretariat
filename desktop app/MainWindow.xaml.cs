﻿using System;
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
    // TODO: editable hotkeys
    // TODO: group add and class add for student and teacher
    // TODO: raports

    public partial class MainWindow : Window
    {

        public string asd { get; set; } = "aqsd";
        #region commands
        
        public static RoutedCommand ExportCmd = new RoutedCommand();
        public static RoutedCommand ImportCmd = new RoutedCommand();
        public static RoutedCommand FilterResetCmd = new RoutedCommand();
        public static RoutedCommand FilterApplyCmd = new RoutedCommand();

        private void SetupCommands()
        {
            this.CommandBindings.Add(
                new CommandBinding(
                    ExportCmd,
                    Export));
            this.CommandBindings.Add(
                new CommandBinding(
                    ImportCmd,
                    Import));
            this.CommandBindings.Add(
                new CommandBinding(
                    FilterResetCmd,
                    FilterReset));
            this.CommandBindings.Add(
                new CommandBinding(
                    FilterApplyCmd,
                    FilterApply));
        }

        #endregion

        #region hotkeys
        public static Hotkey ExportHotkey;
        public Hotkey ImportHotkey;
        public Hotkey FilterReseHotkey;
        public Hotkey FilterApplyHotkey;

        private void SetupHotkeys()
        {
            ImportHotkey = new Hotkey(Key.I, ModifierKeys.Control, ImportCmd, this);
            ExportHotkey = new Hotkey(Key.S, ModifierKeys.Control, ExportCmd, this);
            FilterReseHotkey = new Hotkey(Key.R, ModifierKeys.Control, FilterResetCmd, this);
            FilterApplyHotkey = new Hotkey(Key.F, ModifierKeys.Control, FilterApplyCmd, this);
        }
        #endregion

        School school = new School();

        public MainWindow()
        {
            SetupCommands();
            SetupHotkeys();
            InitializeComponent();

            FilterHelpButton.Click += FilterHelpButton_Click;
            filterBox.KeyDown += filterBox_KeyDown;

            student_list_grid.ItemsSource = school.students.DefaultView;
            group_list_grid.ItemsSource = school.groups.DefaultView;
            teacher_list_grid.ItemsSource = school.teachers.DefaultView;

        }

        private void FilterHelpButton_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://docs.microsoft.com/en-us/dotnet/api/system.data.datacolumn.expression";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
        }

        private void FilterReset(object sender, RoutedEventArgs e)
        {
            school.students.DefaultView.RowFilter = "";
            school.groups.DefaultView.RowFilter = "";
            school.teachers.DefaultView.RowFilter = "";
        }

        private void filterBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                FilterApply(this, new RoutedEventArgs());
            }
        }

        private void FilterApply(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (tableControl.SelectedIndex)
                {
                    case 0:
                        school.students.DefaultView.RowFilter = filterBox.Text;
                        break;
                    case 1:
                        school.groups.DefaultView.RowFilter = filterBox.Text;
                        break;
                    case 2:
                        school.teachers.DefaultView.RowFilter = filterBox.Text;
                        break;
                }
                LinearGradientBrush myBrush = new LinearGradientBrush();
                filterBox.Background = myBrush;
            }
            catch(System.Data.InvalidExpressionException)
            {
                LinearGradientBrush myBrush = new LinearGradientBrush();
                myBrush.GradientStops.Add(new GradientStop(Color.FromArgb(200, 190,0,0) , 1));
                filterBox.Background = myBrush;
            }
        }

        private void Export(object sender, RoutedEventArgs e)
        {
            IEmodule.export(school);
        }

        private void Import(object sender, RoutedEventArgs e)
        {
            School importrted = IEmodule.import();
            student_list_grid.ItemsSource = importrted.students.DefaultView;
            group_list_grid.ItemsSource = importrted.groups.DefaultView;
            teacher_list_grid.ItemsSource = importrted.teachers.DefaultView;
        }
        private void EditHotkey(object sender,RoutedEventArgs e)
        {
            Debug.WriteLine("test");
        }
    }
}
