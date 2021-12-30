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
    // TODO: group add and class add for student and teacher
    // TODO: raports

    public partial class MainWindow : Window
    {


        #region hotkeys
        public static Hotkey ExportHotkey;
        public static Hotkey ImportHotkey;
        public static Hotkey FilterResetHotkey;
        public static Hotkey FilterApplyHotkey;


        private void SetupHotkeys()
        {
            ImportHotkey = new Hotkey(Key.I, ModifierKeys.Control, Import, this);
            ExportHotkey = new Hotkey(Key.S, ModifierKeys.Control, Export, this);
            FilterResetHotkey = new Hotkey(Key.R, ModifierKeys.Control, FilterReset, this);
            FilterApplyHotkey = new Hotkey(Key.F, ModifierKeys.Control, FilterApply, this);
        }
        #endregion

        School school = new School();


        Key LastKeyPressed;
        ModifierKeys LastModifierPressed;
        MenuItem LastMenuItem;


        private void TogglePopup_OnClick(object sender, EventArgs e) => this.Popup.IsOpen ^= true;
        public MainWindow()
        {
            SetupHotkeys();
            InitializeComponent();


            filterBox.KeyDown += filterBox_KeyDown;
            this.KeyDown += Popup_KeyDown;


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


        public void test(object sender, EventArgs e)
        {
            Popup.IsOpen = true;

            this.LastMenuItem = (sender as MenuItem);

        }
        public void test2(object sender, EventArgs e)
        {
            TogglePopup_OnClick(null,null);

            (this.LastMenuItem.DataContext as Hotkey).UpdateKey(LastKeyPressed, LastModifierPressed);
            this.LastMenuItem.InputGestureText = (this.LastMenuItem.DataContext as Hotkey).InputGestureText;
        }


        private void Popup_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Popup.IsOpen) return;
            Debug.WriteLine("test");
            e.Handled = true;
            var modifiers = Keyboard.Modifiers;
            var key = e.Key;
            if (key == Key.System)
            {
                key = e.SystemKey;
            }

            if (modifiers == ModifierKeys.None &&
                (key == Key.Delete || key == Key.Back || key == Key.Escape))
            {
                return;
            }

            if (key == Key.LeftCtrl ||
                key == Key.RightCtrl ||
                key == Key.LeftAlt ||
                key == Key.RightAlt ||
                key == Key.LeftShift ||
                key == Key.RightShift ||
                key == Key.LWin ||
                key == Key.RWin ||
                key == Key.Clear ||
                key == Key.OemClear ||
                key == Key.Apps)
                {
                    return;
                }
            LastKeyPressed = key;
            LastModifierPressed = modifiers;

            var str = new StringBuilder();

            if (modifiers.HasFlag(ModifierKeys.Control))
                str.Append("Ctrl + ");
            if (modifiers.HasFlag(ModifierKeys.Shift))
                str.Append("Shift + ");
            if (modifiers.HasFlag(ModifierKeys.Alt))
                str.Append("Alt + ");
            if (modifiers.HasFlag(ModifierKeys.Windows))
                str.Append("Win + ");

            str.Append(key);

            PopupText.Content = str.ToString();
        }
    }
}
