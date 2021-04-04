namespace Store_Organiser
{
    partial class AllForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.addPaymentNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.saleDetailNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.deleteSaleNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.addSalenavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tableAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDepDataSet = new Store_Organiser.MedDepDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber_alband = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.table_AllTableAdapter = new Store_Organiser.MedDepDataSetTableAdapters.Table_AllTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.tileNavPane1.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane1.AppearanceSelected.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.tileNavPane1.AppearanceSelected.Options.UseFont = true;
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Buttons.Add(this.navButton3);
            this.tileNavPane1.Buttons.Add(this.addPaymentNavButton);
            this.tileNavPane1.Buttons.Add(this.saleDetailNavButton);
            this.tileNavPane1.Buttons.Add(this.deleteSaleNavButton);
            this.tileNavPane1.Buttons.Add(this.addSalenavButton);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(814, 42);
            this.tileNavPane1.TabIndex = 32;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            this.navButton2.Visible = false;
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton3.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.navButton3.AppearanceHovered.Options.UseBackColor = true;
            this.navButton3.Caption = "إغلاق";
            this.navButton3.Glyph = ((System.Drawing.Image)(resources.GetObject("navButton3.Glyph")));
            this.navButton3.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton3.Name = "navButton3";
            this.navButton3.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navButton3_ElementClick);
            // 
            // addPaymentNavButton
            // 
            this.addPaymentNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addPaymentNavButton.Caption = "طباعة";
            this.addPaymentNavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addPaymentNavButton.Glyph")));
            this.addPaymentNavButton.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addPaymentNavButton.Name = "addPaymentNavButton";
            this.addPaymentNavButton.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.addPaymentNavButton_ElementClick);
            // 
            // saleDetailNavButton
            // 
            this.saleDetailNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.saleDetailNavButton.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.saleDetailNavButton.AppearanceHovered.Options.UseBackColor = true;
            this.saleDetailNavButton.Caption = "تفاصيل ";
            this.saleDetailNavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("saleDetailNavButton.Glyph")));
            this.saleDetailNavButton.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.saleDetailNavButton.Name = "saleDetailNavButton";
            this.saleDetailNavButton.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.saleDetailNavButton_ElementClick);
            // 
            // deleteSaleNavButton
            // 
            this.deleteSaleNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.deleteSaleNavButton.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.deleteSaleNavButton.AppearanceHovered.Options.UseBackColor = true;
            this.deleteSaleNavButton.Caption = "حذف";
            this.deleteSaleNavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteSaleNavButton.Glyph")));
            this.deleteSaleNavButton.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.deleteSaleNavButton.Name = "deleteSaleNavButton";
            this.deleteSaleNavButton.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.deleteSaleNavButton_ElementClick);
            // 
            // addSalenavButton
            // 
            this.addSalenavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addSalenavButton.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.addSalenavButton.AppearanceHovered.Options.UseBackColor = true;
            this.addSalenavButton.Caption = "إضافة أو تعديل الملاحظات";
            this.addSalenavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addSalenavButton.Glyph")));
            this.addSalenavButton.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addSalenavButton.Name = "addSalenavButton";
            this.addSalenavButton.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.addSalenavButton_ElementClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tableAllBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(814, 332);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // tableAllBindingSource
            // 
            this.tableAllBindingSource.DataMember = "Table_All";
            this.tableAllBindingSource.DataSource = this.medDepDataSet;
            // 
            // medDepDataSet
            // 
            this.medDepDataSet.DataSetName = "MedDepDataSet";
            this.medDepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colName,
            this.colNumber_alband,
            this.colAmount,
            this.colNote});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colName
            // 
            this.colName.Caption = "اسم المادة";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colNumber_alband
            // 
            this.colNumber_alband.Caption = "رقم البند";
            this.colNumber_alband.FieldName = "Number_alband";
            this.colNumber_alband.Name = "colNumber_alband";
            this.colNumber_alband.Visible = true;
            this.colNumber_alband.VisibleIndex = 3;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "الكمية";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 1;
            // 
            // colNote
            // 
            this.colNote.Caption = "الملاحظات";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 0;
            // 
            // table_AllTableAdapter
            // 
            this.table_AllTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(776, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 28);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "بحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(579, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(191, 28);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(512, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 28);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "مسح";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 374);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "AllForm";
            this.Text = "إجمالي المواد";
            this.Load += new System.EventHandler(this.AllForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraBars.Navigation.NavButton addPaymentNavButton;
        private DevExpress.XtraBars.Navigation.NavButton saleDetailNavButton;
        private DevExpress.XtraBars.Navigation.NavButton deleteSaleNavButton;
        private DevExpress.XtraBars.Navigation.NavButton addSalenavButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MedDepDataSet medDepDataSet;
        private System.Windows.Forms.BindingSource tableAllBindingSource;
        private MedDepDataSetTableAdapters.Table_AllTableAdapter table_AllTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber_alband;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}