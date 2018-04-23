namespace Q245442 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource();
            this.nwindDataSet = new Q245442.nwindDataSet();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection();
            this.rowCategoryID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCategoryName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDescription = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoriesTableAdapter = new Q245442.nwindDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl
            // 
            this.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl.ImageList = this.imageCollection1;
            this.vGridControl.Location = new System.Drawing.Point(0, 0);
            this.vGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.OptionsBehavior.Editable = false;
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowCategoryID,
            this.rowCategoryName,
            this.rowDescription});
            this.vGridControl.Size = new System.Drawing.Size(1113, 112);
            this.vGridControl.TabIndex = 0;
            this.vGridControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnVGridControlMouseUp);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // rowCategoryID
            // 
            this.rowCategoryID.Name = "rowCategoryID";
            this.rowCategoryID.Properties.Caption = "CategoryID";
            this.rowCategoryID.Properties.FieldName = "CategoryID";
            // 
            // rowCategoryName
            // 
            this.rowCategoryName.Height = 16;
            this.rowCategoryName.Name = "rowCategoryName";
            this.rowCategoryName.Properties.Caption = "CategoryName";
            this.rowCategoryName.Properties.FieldName = "CategoryName";
            // 
            // rowDescription
            // 
            this.rowDescription.Name = "rowDescription";
            this.rowDescription.Properties.Caption = "Description";
            this.rowDescription.Properties.FieldName = "Description";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 112);
            this.Controls.Add(this.vGridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Q245442.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCategoryID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCategoryName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDescription;
        private DevExpress.Utils.ImageCollection imageCollection1;

    }
}

