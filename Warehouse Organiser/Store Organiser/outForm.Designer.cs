namespace Store_Organiser
{
    partial class outForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(outForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.addPaymentNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.saleDetailNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.deleteSaleNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.EditSalenavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.addSalenavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tableOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDepDataSet = new Store_Organiser.MedDepDataSet();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_Out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthe_recp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber_Alband_Out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote_Out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableOutTableAdapter = new Store_Organiser.MedDepDataSetTableAdapters.TableOutTableAdapter();
            this.tableAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_AllTableAdapter = new Store_Organiser.MedDepDataSetTableAdapters.Table_AllTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).BeginInit();
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
            this.tileNavPane1.Buttons.Add(this.EditSalenavButton);
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
            this.tileNavPane1.Size = new System.Drawing.Size(734, 42);
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
            // EditSalenavButton
            // 
            this.EditSalenavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.EditSalenavButton.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.EditSalenavButton.AppearanceHovered.Options.UseBackColor = true;
            this.EditSalenavButton.Caption = "تعديل";
            this.EditSalenavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("EditSalenavButton.Glyph")));
            this.EditSalenavButton.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.EditSalenavButton.Name = "EditSalenavButton";
            this.EditSalenavButton.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.EditSalenavButton_ElementClick);
            // 
            // addSalenavButton
            // 
            this.addSalenavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addSalenavButton.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.addSalenavButton.AppearanceHovered.Options.UseBackColor = true;
            this.addSalenavButton.Caption = "إضافة";
            this.addSalenavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addSalenavButton.Glyph")));
            this.addSalenavButton.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addSalenavButton.Name = "addSalenavButton";
            this.addSalenavButton.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.addSalenavButton_ElementClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tableOutBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 319);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // tableOutBindingSource
            // 
            this.tableOutBindingSource.DataMember = "TableOut";
            this.tableOutBindingSource.DataSource = this.medDepDataSet;
            // 
            // medDepDataSet
            // 
            this.medDepDataSet.DataSetName = "MedDepDataSet";
            this.medDepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_Out,
            this.colthe_recp,
            this.colNumber_Alband_Out,
            this.colDate_out,
            this.colName_out,
            this.colAmount_out,
            this.colNote_Out});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            // 
            // colid_Out
            // 
            this.colid_Out.FieldName = "id_Out";
            this.colid_Out.Name = "colid_Out";
            // 
            // colthe_recp
            // 
            this.colthe_recp.Caption = "المرسل إليه";
            this.colthe_recp.FieldName = "the_recp";
            this.colthe_recp.Name = "colthe_recp";
            this.colthe_recp.Visible = true;
            this.colthe_recp.VisibleIndex = 5;
            // 
            // colNumber_Alband_Out
            // 
            this.colNumber_Alband_Out.Caption = "رقم البند";
            this.colNumber_Alband_Out.FieldName = "Number_Alband_Out";
            this.colNumber_Alband_Out.Name = "colNumber_Alband_Out";
            this.colNumber_Alband_Out.Visible = true;
            this.colNumber_Alband_Out.VisibleIndex = 4;
            // 
            // colDate_out
            // 
            this.colDate_out.Caption = "التاريخ";
            this.colDate_out.FieldName = "Date_out";
            this.colDate_out.Name = "colDate_out";
            this.colDate_out.Visible = true;
            this.colDate_out.VisibleIndex = 1;
            // 
            // colName_out
            // 
            this.colName_out.Caption = "اسم المادة";
            this.colName_out.FieldName = "Name_out";
            this.colName_out.Name = "colName_out";
            this.colName_out.Visible = true;
            this.colName_out.VisibleIndex = 3;
            // 
            // colAmount_out
            // 
            this.colAmount_out.Caption = "الكمية";
            this.colAmount_out.FieldName = "Amount_out";
            this.colAmount_out.Name = "colAmount_out";
            this.colAmount_out.Visible = true;
            this.colAmount_out.VisibleIndex = 2;
            // 
            // colNote_Out
            // 
            this.colNote_Out.Caption = "الملاحظات";
            this.colNote_Out.FieldName = "Note_Out";
            this.colNote_Out.Name = "colNote_Out";
            this.colNote_Out.Visible = true;
            this.colNote_Out.VisibleIndex = 0;
            // 
            // tableOutTableAdapter
            // 
            this.tableOutTableAdapter.ClearBeforeFill = true;
            // 
            // tableAllBindingSource
            // 
            this.tableAllBindingSource.DataMember = "Table_All";
            this.tableAllBindingSource.DataSource = this.medDepDataSet;
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
            this.labelControl2.Location = new System.Drawing.Point(696, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 28);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "بحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(499, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(191, 28);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(432, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 28);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "مسح";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // outForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "outForm";
            this.Text = "مخرجات";
            this.Load += new System.EventHandler(this.outForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).EndInit();
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
        private DevExpress.XtraBars.Navigation.NavButton EditSalenavButton;
        private DevExpress.XtraBars.Navigation.NavButton addSalenavButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private MedDepDataSet medDepDataSet;
        private System.Windows.Forms.BindingSource tableOutBindingSource;
        private MedDepDataSetTableAdapters.TableOutTableAdapter tableOutTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid_Out;
        private DevExpress.XtraGrid.Columns.GridColumn colthe_recp;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber_Alband_Out;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_out;
        private DevExpress.XtraGrid.Columns.GridColumn colName_out;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount_out;
        private DevExpress.XtraGrid.Columns.GridColumn colNote_Out;
        private System.Windows.Forms.BindingSource tableAllBindingSource;
        private MedDepDataSetTableAdapters.Table_AllTableAdapter table_AllTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}