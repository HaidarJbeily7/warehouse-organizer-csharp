using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Organiser
{
    
       
    public partial class AddEditViewallForm : Form
    {
        public string Mode = "INSERT";
        public int id = 0;
        public AddEditViewallForm()
        {
            InitializeComponent();
        }

        private void navBtnCancel_in_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void AddEditViewallForm_Load(object sender, EventArgs e)
        {
            this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
            switch (Mode)
            {
                case "INSERT":
                    this.Text = "إضافة ملاحظات";
                    break;
                case "VIEW":
                    this.Text = "تفاصيل";
                    notesTextBox.Enabled = false;
                    navBtnSave_in.Visible = false;
                    break;


            }
        }

        private void navBtnSave_in_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            try
            {
                this.table_AllTableAdapter.UpdateQuery(notesTextBox.Text, id, id);
                MessageBox.Show("تمت إضافة البيانات المحددة بنجاح", "تمت الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
