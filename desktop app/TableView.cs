using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace desktop_app
{
    public class TableView : TabItem
    {
        public DataGrid dataGrid = new DataGrid();

        public TableView(System.Collections.IEnumerable _ItemsSource)
        {
            this.dataGrid.ItemsSource = _ItemsSource;
            this.Content = dataGrid;
        }
        public TableView()
        {
            this.Content = dataGrid;
        }

    }
}
