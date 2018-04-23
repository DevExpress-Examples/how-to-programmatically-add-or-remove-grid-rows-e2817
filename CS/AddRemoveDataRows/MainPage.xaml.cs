using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace AddRemoveDataRows {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = new ProductList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            (grid.DataSource as ProductList).Add(new Product() { ProductName = "(Empty) Product Name" });
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if(grid.IsValidRowHandle(grid.View.FocusedRowHandle))
                grid.View.DeleteRow(grid.View.FocusedRowHandle);
        }
    }
}
