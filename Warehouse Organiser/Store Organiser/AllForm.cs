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
    public partial class AllForm : Form
    {
        public AllForm()
        {
            InitializeComponent();
        }

        private void AllForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDepDataSet.Table_All' table. You can move, or remove it, as needed.
            this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);

        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void addSalenavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewallForm frm = new AddEditViewallForm();
            frm.id = (int)(this.tableAllBindingSource.Current as DataRowView)["id"];
            frm.Mode = "INSERT";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
                this.tableAllBindingSource.Position = tableAllBindingSource.Find("id", frm.id);
            }
        }

        private void EditSalenavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewallForm frm = new AddEditViewallForm();
            frm.id = (int)(this.tableAllBindingSource.Current as DataRowView)["id"];
            frm.Mode = "EDIT";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
                this.tableAllBindingSource.Position = tableAllBindingSource.Find("id", frm.id);
            }
        }

        private void saleDetailNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewallForm frm = new AddEditViewallForm();
            frm.id = (int)(this.tableAllBindingSource.Current as DataRowView)["id"];
            frm.Mode = "VIEW";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
                this.tableAllBindingSource.Position = tableAllBindingSource.Find("id", frm.id);
            }
        }

        private void deleteSaleNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            int CurrentID = (int)(this.tableAllBindingSource.Current as DataRowView)["id"];
            double CurrentAmount = (double)this.table_AllTableAdapter.GetAmountByID(CurrentID);
            if (CurrentAmount > 0)
            {

                MessageBox.Show("لا يمكن حذف البيانات المحددة ", "عذراً", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("هل تريد بالتأكيد حذف هذه البيانات", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.table_AllTableAdapter.DeleteQuery(CurrentID);
                this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
                MessageBox.Show("تم حذف البيانات المحددة بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addPaymentNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            GridPrinting.PrintGrid(gridControl1, gridView2, "إجمالي المواد");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView2.FindFilterText = txtSearch.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
