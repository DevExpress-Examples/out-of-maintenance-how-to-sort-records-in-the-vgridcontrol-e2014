using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using Q245442.Collections;
using System.ComponentModel;

namespace Q245442 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private SortableBindingList categoriesSortableSource;

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            this.categoriesSortableSource = new SortableBindingList(this.BindingContext, this.categoriesBindingSource);
            this.vGridControl.DataSource = this.categoriesSortableSource;
        }

        private void OnVGridControlMouseUp(object sender, MouseEventArgs e) {
            VGridControl grid = (VGridControl)sender;
            VGridHitInfo hitInfo = grid.CalcHitInfo(e.Location);
            if (!(hitInfo.HitInfoType == HitInfoTypeEnum.HeaderCell)) return;
            ListSortDirection currentSortOrder = ListSortDirection.Ascending;
            if (hitInfo.Row.Tag != null) {
                currentSortOrder = (ListSortDirection)hitInfo.Row.Tag;
                if (currentSortOrder == ListSortDirection.Ascending)
                    currentSortOrder = ListSortDirection.Descending;
                else currentSortOrder = ListSortDirection.Ascending;
            }
            foreach (BaseRow row in grid.Rows) row.Properties.ImageIndex = -1;
            hitInfo.Row.Properties.ImageIndex = currentSortOrder == ListSortDirection.Ascending ? 0 : 1;
            hitInfo.Row.Tag = currentSortOrder;
            this.categoriesSortableSource.ApplySort(hitInfo.Row.Properties.FieldName, currentSortOrder);
        }
    }
}