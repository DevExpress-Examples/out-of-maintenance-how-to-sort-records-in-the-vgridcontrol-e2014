Namespace Q245442
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.vGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource()
            Me.nwindDataSet = New Q245442.nwindDataSet()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection()
            Me.rowCategoryID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowCategoryName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.categoriesTableAdapter = New Q245442.nwindDataSetTableAdapters.CategoriesTableAdapter()
            DirectCast(Me.vGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' vGridControl
            ' 
            Me.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl.ImageList = Me.imageCollection1
            Me.vGridControl.Location = New System.Drawing.Point(0, 0)
            Me.vGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.vGridControl.Name = "vGridControl"
            Me.vGridControl.OptionsBehavior.Editable = False
            Me.vGridControl.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowCategoryID, Me.rowCategoryName, Me.rowDescription})
            Me.vGridControl.Size = New System.Drawing.Size(1113, 112)
            Me.vGridControl.TabIndex = 0
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataMember = "Categories"
            Me.categoriesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            ' 
            ' rowCategoryID
            ' 
            Me.rowCategoryID.Name = "rowCategoryID"
            Me.rowCategoryID.Properties.Caption = "CategoryID"
            Me.rowCategoryID.Properties.FieldName = "CategoryID"
            ' 
            ' rowCategoryName
            ' 
            Me.rowCategoryName.Height = 16
            Me.rowCategoryName.Name = "rowCategoryName"
            Me.rowCategoryName.Properties.Caption = "CategoryName"
            Me.rowCategoryName.Properties.FieldName = "CategoryName"
            ' 
            ' rowDescription
            ' 
            Me.rowDescription.Name = "rowDescription"
            Me.rowDescription.Properties.Caption = "Description"
            Me.rowDescription.Properties.FieldName = "Description"
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1113, 112)
            Me.Controls.Add(Me.vGridControl)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.vGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents vGridControl As DevExpress.XtraVerticalGrid.VGridControl
        Private nwindDataSet As nwindDataSet
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private categoriesTableAdapter As Q245442.nwindDataSetTableAdapters.CategoriesTableAdapter
        Private rowCategoryID As DevExpress.XtraVerticalGrid.Rows.EditorRow
        Private rowCategoryName As DevExpress.XtraVerticalGrid.Rows.EditorRow
        Private rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
        Private imageCollection1 As DevExpress.Utils.ImageCollection

    End Class
End Namespace

