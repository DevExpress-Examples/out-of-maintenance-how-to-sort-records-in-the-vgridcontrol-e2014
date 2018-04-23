Imports System.ComponentModel
Imports System.Collections
Imports DevExpress.Data
Imports System.Windows.Forms
Imports System
Imports DevExpress.Data.Helpers

Namespace Q245442.Collections
    Public Class SortableBindingList
        Implements IBindingList

        Private DataController As ListSourceDataController

        Public Sub New(ByVal bindingContext As BindingContext, ByVal sourceList As IList)
            Me.DataController = New ListSourceDataController()
            Me.DataController.SetListSource(bindingContext, sourceList, String.Empty)
        End Sub

        Protected Overridable Sub ApplySort(ByVal columnInfo As DataColumnInfo, ByVal direction As ListSortDirection)
            Dim sortOrder As ColumnSortOrder = ColumnSortOrder.Ascending
            If direction = ListSortDirection.Descending Then
                sortOrder = ColumnSortOrder.Descending
            End If
            Dim sortInfo As New DataColumnSortInfo(columnInfo, sortOrder)
            Me.DataController.SortInfo.ClearAndAddRange(sortInfo)
        End Sub

        Public Overridable Sub RemoveSort()
            Me.DataController.SortInfo.Clear()
        End Sub

        Public Sub ApplySort(ByVal [property] As String, ByVal direction As ListSortDirection)
            Dim column As DataColumnInfo = Me.DataController.FindColumn([property])
            If column Is Nothing Then
                Return
            End If
            Me.ApplySort(column, direction)
        End Sub

        #Region "IBindingList members"
        Private Sub IBindingList_AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
        End Sub

        Private Function IBindingList_AddNew() As Object Implements IBindingList.AddNew
            Throw New NotSupportedException("Adding a new item to the list is not supported")
        End Function

        Private ReadOnly Property IBindingList_AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return True
            End Get
        End Property

        Private ReadOnly Property IBindingList_AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_AllowRemove() As Boolean Implements IBindingList.AllowRemove
            Get
                Return False
            End Get
        End Property

        Private Sub IBindingList_ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection) Implements IBindingList.ApplySort
            Dim columnInfo As DataColumnInfo = Me.DataController.FindColumn([property].Name)
            If columnInfo Is Nothing Then
                Return
            End If
            Me.ApplySort(columnInfo, direction)
        End Sub

        Private Function IBindingList_Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Throw New NotSupportedException("Searching is not supported")
        End Function

        Private ReadOnly Property IBindingList_IsSorted() As Boolean Implements IBindingList.IsSorted
            Get
                Return Me.DataController.IsSorted
            End Get
        End Property

        Private Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
            AddHandler(ByVal value As ListChangedEventHandler)
            End AddHandler
            RemoveHandler(ByVal value As ListChangedEventHandler)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
            End RaiseEvent
        End Event

        Private Sub IBindingList_RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
        End Sub

        Private Sub IBindingList_RemoveSort() Implements IBindingList.RemoveSort
            Me.RemoveSort()
        End Sub

        Private ReadOnly Property IBindingList_SortDirection() As ListSortDirection Implements IBindingList.SortDirection
            Get
                Dim result As ListSortDirection = ListSortDirection.Ascending
                If Me.DataController.SortInfo(0).SortOrder = ColumnSortOrder.Descending Then
                    result = ListSortDirection.Descending
                End If
                Return result
            End Get
        End Property

        Private ReadOnly Property IBindingList_SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Return Me.DataController.SortInfo(0).ColumnInfo.PropertyDescriptor
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property

        Private ReadOnly Property IBindingList_SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
            Get
                Return True
            End Get
        End Property
        #End Region
        #Region "IList members"
        Private Function IList_Add(ByVal value As Object) As Integer Implements IList.Add
            Throw New NotSupportedException("The list is read-only")
        End Function

        Private Sub IList_Clear() Implements IList.Clear
            Throw New NotSupportedException("The list is read-only")
        End Sub

        Private Function IList_Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Return Me.DataController.ListSource.Contains(value)
        End Function

        Private Function IList_IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Return Me.DataController.ListSource.IndexOf(value)
        End Function

        Private Sub IList_Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            Throw New NotSupportedException("The list is read-only")
        End Sub

        Private ReadOnly Property IList_IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return Me.DataController.ListSource.IsFixedSize
            End Get
        End Property

        Private ReadOnly Property IList_IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return True
            End Get
        End Property

        Private Sub IList_Remove(ByVal value As Object) Implements IList.Remove
            Throw New NotSupportedException("The list is read-only")
        End Sub

        Private Sub IList_RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            Throw New NotSupportedException("The list is read-only")
        End Sub

        Public Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return Me.DataController.GetRow(index)
            End Get
            Set(ByVal value As Object)
                Throw New NotSupportedException("The list is read-only")
            End Set
        End Property
        #End Region
        #Region "ICollection members"
        Private Sub ICollection_CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            Me.DataController.ListSource.CopyTo(array, index)
        End Sub

        Private ReadOnly Property ICollection_Count() As Integer Implements ICollection.Count
            Get
                Return Me.DataController.VisibleCount
            End Get
        End Property

        Private ReadOnly Property ICollection_IsSynchronized() As Boolean Implements ICollection.IsSynchronized
            Get
                Return Me.DataController.ListSource.IsSynchronized
            End Get
        End Property

        Private ReadOnly Property ICollection_SyncRoot() As Object Implements ICollection.SyncRoot
            Get
                Return Me.DataController.ListSource.SyncRoot
            End Get
        End Property
        #End Region
        #Region "IEnumerator members"
        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return Me.DataController.ListSource.GetEnumerator()
        End Function
        #End Region
    End Class
End Namespace
