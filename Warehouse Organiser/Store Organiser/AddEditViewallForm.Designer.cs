namespace Store_Organiser
{
    partial class AddEditViewallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditViewallForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navBtnCancel_in = new DevExpress.XtraBars.Navigation.NavButton();
            this.navBtnSave_in = new DevExpress.XtraBars.Navigation.NavButton();
            this.Number_alband = new System.Windows.Forms.TextBox();
            this.tableAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDepDataSet = new Store_Organiser.MedDepDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.table_AllTableAdapter = new Store_Organiser.MedDepDataSetTableAdapters.Table_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).BeginInit();
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
            this.tileNavPane1.Buttons.Add(this.navBtnCancel_in);
            this.tileNavPane1.Buttons.Add(this.navBtnSave_in);
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
            this.tileNavPane1.Size = new System.Drawing.Size(593, 42);
            this.tileNavPane1.TabIndex = 69;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            this.navButton2.Visible = false;
            // 
            // navBtnCancel_in
            // 
            this.navBtnCancel_in.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navBtnCancel_in.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.navBtnCancel_in.AppearanceHovered.Options.UseBackColor = true;
            this.navBtnCancel_in.AppearanceSelected.BackColor = System.Drawing.Color.Coral;
            this.navBtnCancel_in.AppearanceSelected.Options.UseBackColor = true;
            this.navBtnCancel_in.Caption = "إغلاق";
            this.navBtnCancel_in.Glyph = ((System.Drawing.Image)(resources.GetObject("navBtnCancel_in.Glyph")));
            this.navBtnCancel_in.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navBtnCancel_in.Name = "navBtnCancel_in";
            this.navBtnCancel_in.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navBtnCancel_in_ElementClick);
            // 
            // navBtnSave_in
            // 
            this.navBtnSave_in.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navBtnSave_in.AppearanceHovered.BackColor = System.Drawing.Color.Coral;
            this.navBtnSave_in.AppearanceHovered.Options.UseBackColor = true;
            this.navBtnSave_in.AppearanceSelected.BackColor = System.Drawing.Color.Coral;
            this.navBtnSave_in.AppearanceSelected.Options.UseBackColor = true;
            this.navBtnSave_in.Caption = "حفظ";
            this.navBtnSave_in.Glyph = ((System.Drawing.Image)(resources.GetObject("navBtnSave_in.Glyph")));
            this.navBtnSave_in.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navBtnSave_in.Name = "navBtnSave_in";
            this.navBtnSave_in.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navBtnSave_in_ElementClick);
            // 
            // Number_alband
            // 
            this.Number_alband.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableAllBindingSource, "Number_alband", true));
            this.Number_alband.Enabled = false;
            this.Number_alband.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_alband.Location = new System.Drawing.Point(315, 193);
            this.Number_alband.Name = "Number_alband";
            this.Number_alband.Size = new System.Drawing.Size(145, 30);
            this.Number_alband.TabIndex = 108;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 305);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 107;
            this.label3.Text = "الكمية :";
            // 
            // Amount
            // 
            this.Amount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableAllBindingSource, "Amount", true));
            this.Amount.Enabled = false;
            this.Amount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(315, 303);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(145, 30);
            this.Amount.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 192);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 56);
            this.label2.TabIndex = 105;
            this.label2.Text = "رقم البند :\r\n\r\n";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableAllBindingSource, "Name", true));
            this.Name_TextBox.Enabled = false;
            this.Name_TextBox.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TextBox.Location = new System.Drawing.Point(315, 93);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(145, 30);
            this.Name_TextBox.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 92);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 103;
            this.label1.Text = "اسم المادة :\r\n";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableAllBindingSource, "Note", true));
            this.notesTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(39, 71);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesTextBox.Size = new System.Drawing.Size(235, 282);
            this.notesTextBox.TabIndex = 100;
            this.notesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // table_AllTableAdapter
            // 
            this.table_AllTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditViewallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 376);
            this.Controls.Add(this.Number_alband);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "AddEditViewallForm";
            this.Text = "AddEditViewallForm";
            this.Load += new System.EventHandler(this.AddEditViewallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navBtnCancel_in;
        private DevExpress.XtraBars.Navigation.NavButton navBtnSave_in;
        private System.Windows.Forms.TextBox Number_alband;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.BindingSource tableAllBindingSource;
        private MedDepDataSet medDepDataSet;
        private MedDepDataSetTableAdapters.Table_AllTableAdapter table_AllTableAdapter;
    }
}