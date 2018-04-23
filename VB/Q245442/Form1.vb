Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports Q245442.Collections
Imports System.ComponentModel

Namespace Q245442
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private categoriesSortableSource As SortableBindingList

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
            Me.categoriesSortableSource = New SortableBindingList(Me.BindingContext, Me.categoriesBindingSource)
            Me.vGridControl.DataSource = Me.categoriesSortableSource
        End Sub

        Private Sub OnVGridControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles vGridControl.MouseUp
            Dim grid As VGridControl = DirectCast(sender, VGridControl)
            Dim hitInfo As VGridHitInfo = grid.CalcHitInfo(e.Location)
            If Not(hitInfo.HitInfoType = HitInfoTypeEnum.HeaderCell) Then
                Return
            End If
            Dim currentSortOrder As ListSortDirection = ListSortDirection.Ascending
            If hitInfo.Row.Tag IsNot Nothing Then
                currentSortOrder = CType(hitInfo.Row.Tag, ListSortDirection)
                If currentSortOrder = ListSortDirection.Ascending Then
                    currentSortOrder = ListSortDirection.Descending
                Else
                    currentSortOrder = ListSortDirection.Ascending
                End If
            End If
            For Each row As BaseRow In grid.Rows
                row.Properties.ImageIndex = -1
            Next row
            hitInfo.Row.Properties.ImageIndex = If(currentSortOrder = ListSortDirection.Ascending, 0, 1)
            hitInfo.Row.Tag = currentSortOrder
            Me.categoriesSortableSource.ApplySort(hitInfo.Row.Properties.FieldName, currentSortOrder)
        End Sub
    End Class
End Namespace