namespace Store_Organiser
{
    partial class AddEditViewinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditViewinForm));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navBtnCancel_in = new DevExpress.XtraBars.Navigation.NavButton();
            this.navBtnSave_in = new DevExpress.XtraBars.Navigation.NavButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount_in = new System.Windows.Forms.TextBox();
            this.tableInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medDepDataSet = new Store_Organiser.MedDepDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_in_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateDateEdit_in = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.notesTextBox_in = new System.Windows.Forms.TextBox();
            this.Number_alband_in = new System.Windows.Forms.TextBox();
            this.table_InTableAdapter = new Store_Organiser.MedDepDataSetTableAdapters.Table_InTableAdapter();
            this.tableAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_AllTableAdapter = new Store_Organiser.MedDepDataSetTableAdapters.Table_AllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit_in.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit_in.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).BeginInit();
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
            this.tileNavPane1.Size = new System.Drawing.Size(657, 42);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 262);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 98;
            this.label3.Text = "الكمية :";
            // 
            // Amount_in
            // 
            this.Amount_in.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableInBindingSource, "Amount_In", true));
            this.Amount_in.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_in.Location = new System.Drawing.Point(346, 263);
            this.Amount_in.Name = "Amount_in";
            this.Amount_in.Size = new System.Drawing.Size(145, 30);
            this.Amount_in.TabIndex = 97;
            // 
            // tableInBindingSource
            // 
            this.tableInBindingSource.DataMember = "Table_In";
            this.tableInBindingSource.DataSource = this.medDepDataSet;
            // 
            // medDepDataSet
            // 
            this.medDepDataSet.DataSetName = "MedDepDataSet";
            this.medDepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 172);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 56);
            this.label2.TabIndex = 96;
            this.label2.Text = "رقم البند :\r\n\r\n";
            // 
            // Name_in_TextBox
            // 
            this.Name_in_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableInBindingSource, "Name_In", true));
            this.Name_in_TextBox.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_in_TextBox.Location = new System.Drawing.Point(346, 95);
            this.Name_in_TextBox.Name = "Name_in_TextBox";
            this.Name_in_TextBox.Size = new System.Drawing.Size(145, 30);
            this.Name_in_TextBox.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 94);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "اسم المادة :\r\n";
            // 
            // DateDateEdit_in
            // 
            this.DateDateEdit_in.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tableInBindingSource, "Date_In", true));
            this.DateDateEdit_in.EditValue = null;
            this.DateDateEdit_in.Location = new System.Drawing.Point(346, 342);
            this.DateDateEdit_in.Name = "DateDateEdit_in";
            this.DateDateEdit_in.Properties.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.DateDateEdit_in.Properties.Appearance.Options.UseFont = true;
            this.DateDateEdit_in.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit_in.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit_in.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.DateDateEdit_in.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateDateEdit_in.Properties.Mask.EditMask = "d/M/yyyy";
            this.DateDateEdit_in.Size = new System.Drawing.Size(145, 28);
            this.DateDateEdit_in.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 341);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(67, 28);
            this.label9.TabIndex = 92;
            this.label9.Text = "التاريخ : ";
            // 
            // notesTextBox_in
            // 
            this.notesTextBox_in.BackColor = System.Drawing.Color.LemonChiffon;
            this.notesTextBox_in.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableInBindingSource, "Note_In", true));
            this.notesTextBox_in.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox_in.Location = new System.Drawing.Point(43, 88);
            this.notesTextBox_in.Multiline = true;
            this.notesTextBox_in.Name = "notesTextBox_in";
            this.notesTextBox_in.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesTextBox_in.Size = new System.Drawing.Size(235, 282);
            this.notesTextBox_in.TabIndex = 91;
            this.notesTextBox_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Number_alband_in
            // 
            this.Number_alband_in.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableInBindingSource, "Number_alband_In", true));
            this.Number_alband_in.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_alband_in.Location = new System.Drawing.Point(346, 173);
            this.Number_alband_in.Name = "Number_alband_in";
            this.Number_alband_in.Size = new System.Drawing.Size(145, 30);
            this.Number_alband_in.TabIndex = 99;
            // 
            // table_InTableAdapter
            // 
            this.table_InTableAdapter.ClearBeforeFill = true;
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
            // AddEditViewinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 412);
            this.Controls.Add(this.Number_alband_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_in_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateDateEdit_in);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.notesTextBox_in);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "AddEditViewinForm";
            this.Text = "AddEditViewinForm";
            this.Load += new System.EventHandler(this.AddEditViewinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit_in.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit_in.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navBtnCancel_in;
        private DevExpress.XtraBars.Navigation.NavButton navBtnSave_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Amount_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_in_TextBox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit DateDateEdit_in;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox notesTextBox_in;
        private System.Windows.Forms.TextBox Number_alband_in;
        private System.Windows.Forms.BindingSource tableInBindingSource;
        private MedDepDataSet medDepDataSet;
        private MedDepDataSetTableAdapters.Table_InTableAdapter table_InTableAdapter;
        private System.Windows.Forms.BindingSource tableAllBindingSource;
        private MedDepDataSetTableAdapters.Table_AllTableAdapter table_AllTableAdapter;
    }
}