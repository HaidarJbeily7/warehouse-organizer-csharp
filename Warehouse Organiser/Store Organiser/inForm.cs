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
    public partial class inForm : Form
    {
        public inForm()
        {
            InitializeComponent();
        }

        private void inForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDepDataSet.Table_In' table. You can move, or remove it, as needed.
            this.table_InTableAdapter.Fill(this.medDepDataSet.Table_In);
            this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);

        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void deleteSaleNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            int CurrentID = (int)(this.tableInBindingSource.Current as DataRowView)["id_In"];
            if (MessageBox.Show("هل تريد بالتأكيد حذف هذه البيانات", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                double num_bnd = (double)this.table_InTableAdapter.GetNumberAlbandById(CurrentID);
                try
                {
                    int id3 = Convert.ToInt32(this.table_AllTableAdapter.GetByNumberAlband(num_bnd));

                    double Current_Amount_In = (double)this.table_InTableAdapter.GetAmountinById(CurrentID);
                    double Current_Amount = (double)this.table_AllTableAdapter.GetAmountByID(id3);
                    if (Current_Amount < Current_Amount_In)
                        Current_Amount = 0;
                    else Current_Amount = Current_Amount - Current_Amount_In;

                    this.table_AllTableAdapter.UpdateAmountByID(Current_Amount, id3, id3);

                }
                catch (Exception ex)
                {

                }
                
                this.table_InTableAdapter.DeleteQuery(CurrentID);
                this.table_InTableAdapter.Fill(this.medDepDataSet.Table_In);
                this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
                MessageBox.Show("تم حذف البيانات المحددة بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addSalenavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewinForm frm = new AddEditViewinForm();
      
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.table_InTableAdapter.Fill(this.medDepDataSet.Table_In);
                this.tableInBindingSource.MoveLast();
            }

        }

        private void EditSalenavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewinForm frm = new AddEditViewinForm();
            frm.id_in = (int)(this.tableInBindingSource.Current as DataRowView)["id_In"];
            frm.Mode = "EDIT";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.table_InTableAdapter.Fill(this.medDepDataSet.Table_In);
                this.tableInBindingSource.Position = tableInBindingSource.Find("id_In", frm.id_in);
            }

        }

        private void saleDetailNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewinForm frm = new AddEditViewinForm();
            frm.id_in = (int)(this.tableInBindingSource.Current as DataRowView)["id_In"];
            frm.Mode = "VIEW";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.table_InTableAdapter.Fill(this.medDepDataSet.Table_In);
                this.tableInBindingSource.Position = tableInBindingSource.Find("id_In", frm.id_in);
            }

        }

        private void addPaymentNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            GridPrinting.PrintGrid(gridControl1, gridView1, "مدخلات");
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = txtSearch.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
