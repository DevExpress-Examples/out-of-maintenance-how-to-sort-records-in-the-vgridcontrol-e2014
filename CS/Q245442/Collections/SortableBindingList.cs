using System.ComponentModel;
using System.Collections;
using DevExpress.Data;
using System.Windows.Forms;
using System;
using DevExpress.Data.Helpers;

namespace Q245442.Collections {
    public class SortableBindingList : IBindingList {
        private ListSourceDataController DataController;

        public SortableBindingList(BindingContext bindingContext, IList sourceList) {
            this.DataController = new ListSourceDataController();
            this.DataController.SetListSource(bindingContext, sourceList, string.Empty);
        }

        protected virtual void ApplySort(DataColumnInfo columnInfo, ListSortDirection direction) {
            ColumnSortOrder sortOrder = ColumnSortOrder.Ascending;
            if (direction == ListSortDirection.Descending)
                sortOrder = ColumnSortOrder.Descending;
            DataColumnSortInfo sortInfo = new DataColumnSortInfo(columnInfo, sortOrder);
            this.DataController.SortInfo.ClearAndAddRange(sortInfo);
        }

        public virtual void RemoveSort() {
            this.DataController.SortInfo.Clear();
        }

        public void ApplySort(string property, ListSortDirection direction) {
            DataColumnInfo column = this.DataController.FindColumn(property);
            if (column == null) return;
            this.ApplySort(column, direction); 
        }

        #region IBindingList members
        void IBindingList.AddIndex(PropertyDescriptor property) { }

        object IBindingList.AddNew() {
            throw new NotSupportedException("Adding a new item to the list is not supported");
        }

        bool IBindingList.AllowEdit {
            get { return true; }
        }

        bool IBindingList.AllowNew {
            get { return false; }
        }

        bool IBindingList.AllowRemove {
            get { return false; }
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) {
            DataColumnInfo columnInfo = this.DataController.FindColumn(property.Name);
            if (columnInfo == null) return;
            this.ApplySort(columnInfo, direction);
        }

        int IBindingList.Find(PropertyDescriptor property, object key) {
            throw new NotSupportedException("Searching is not supported");
        }

        bool IBindingList.IsSorted {
            get { return this.DataController.IsSorted; }
        }

        event ListChangedEventHandler IBindingList.ListChanged {
            add { }
            remove { }
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property) { }

        void IBindingList.RemoveSort() {
            this.RemoveSort();
        }

        ListSortDirection IBindingList.SortDirection {
            get {
                ListSortDirection result = ListSortDirection.Ascending;
                if (this.DataController.SortInfo[0].SortOrder == ColumnSortOrder.Descending)
                    result = ListSortDirection.Descending;
                return result;
            }
        }

        PropertyDescriptor IBindingList.SortProperty {
            get { return this.DataController.SortInfo[0].ColumnInfo.PropertyDescriptor; }
        }

        bool IBindingList.SupportsChangeNotification {
            get { return false; }
        }

        bool IBindingList.SupportsSearching {
            get { return false; }
        }

        bool IBindingList.SupportsSorting {
            get { return true; }
        }
        #endregion
        #region IList members
        int IList.Add(object value) {
            throw new NotSupportedException("The list is read-only");
        }

        void IList.Clear() {
            throw new NotSupportedException("The list is read-only");
        }

        bool IList.Contains(object value) {
            return this.DataController.ListSource.Contains(value);
        }

        int IList.IndexOf(object value) {
            return this.DataController.ListSource.IndexOf(value);
        }

        void IList.Insert(int index, object value) {
            throw new NotSupportedException("The list is read-only");
        }

        bool IList.IsFixedSize {
            get { return this.DataController.ListSource.IsFixedSize; }
        }

        bool IList.IsReadOnly {
            get { return true; }
        }

        void IList.Remove(object value) {
            throw new NotSupportedException("The list is read-only");
        }

        void IList.RemoveAt(int index) {
            throw new NotSupportedException("The list is read-only");
        }

        object IList.this[int index] {
            get { return this.DataController.GetRow(index); }
            set { throw new NotSupportedException("The list is read-only"); }
        }
        #endregion
        #region ICollection members
        void ICollection.CopyTo(Array array, int index) {
            this.DataController.ListSource.CopyTo(array, index);
        }

        int ICollection.Count {
            get { return this.DataController.VisibleCount; }
        }

        bool ICollection.IsSynchronized {
            get { return this.DataController.ListSource.IsSynchronized; }
        }

        object ICollection.SyncRoot {
            get { return this.DataController.ListSource.SyncRoot; }
        }
        #endregion
        #region IEnumerator members
        IEnumerator IEnumerable.GetEnumerator() {
            return this.DataController.ListSource.GetEnumerator();
        }
        #endregion
    }
}
