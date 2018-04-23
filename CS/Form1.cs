using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Northwind;
using DevExpress.XtraGrid.Views.Grid;

namespace FilteredAssociation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e) {
            GridView masterGrid = sender as GridView;
            Category category = (Category)masterGrid.GetRow(e.RowHandle);
            e.ChildList = category.AvailableProducts;
        }
    }
}