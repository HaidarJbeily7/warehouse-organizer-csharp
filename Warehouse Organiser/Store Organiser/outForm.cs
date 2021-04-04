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
    public partial class outForm : Form
    {
        public outForm()
        {
            InitializeComponent();
        }

        private void outForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medDepDataSet.TableOut' table. You can move, or remove it, as needed.
            this.tableOutTableAdapter.Fill(this.medDepDataSet.TableOut);

        }

        private void navButton3_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void addSalenavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewoutForm frm = new AddEditViewoutForm();
         
            
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.tableOutTableAdapter.Fill(this.medDepDataSet.TableOut);
                this.tableOutBindingSource.MoveLast();
            }
        }

        private void EditSalenavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewoutForm frm = new AddEditViewoutForm();
            frm.id_out = (int)(this.tableOutBindingSource.Current as DataRowView)["id_Out"];
            frm.Mode = "EDIT";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.tableOutTableAdapter.Fill(this.medDepDataSet.TableOut);
                this.tableOutBindingSource.Position = tableOutBindingSource.Find("id_Out", frm.id_out);
            }
        }

        private void saleDetailNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddEditViewoutForm frm = new AddEditViewoutForm();
            frm.id_out = (int)(this.tableOutBindingSource.Current as DataRowView)["id_Out"];
            frm.Mode = "VIEW";
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.tableOutTableAdapter.Fill(this.medDepDataSet.TableOut);
                this.tableOutBindingSource.Position = tableOutBindingSource.Find("id_Out", frm.id_out);
            }
        }

        private void deleteSaleNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            int CurrentID = (int)(this.tableOutBindingSource.Current as DataRowView)["id_Out"];
            if (MessageBox.Show("هل تريد بالتأكيد حذف هذه البيانات", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                double num_bnd = (double)this.tableOutTableAdapter.GetNumberAlbandById(CurrentID);
                try
                {
                    
                    int id3 = Convert.ToInt32(this.table_AllTableAdapter.GetByNumberAlband(num_bnd));

                    double Current_Amount_Out = (double)this.tableOutTableAdapter.GetAmountOutById(CurrentID);
                    double Current_Amount = (double)this.table_AllTableAdapter.GetAmountByID(id3);
                    
                     Current_Amount = Current_Amount + Current_Amount_Out;

                    this.table_AllTableAdapter.UpdateAmountByID(Current_Amount, id3, id3);

                }
                catch (Exception ex)
                {

                }

                this.tableOutTableAdapter.DeleteQuery(CurrentID);
                this.tableOutTableAdapter.Fill(this.medDepDataSet.TableOut);
                this.table_AllTableAdapter.Fill(this.medDepDataSet.Table_All);
                MessageBox.Show("تم حذف البيانات المحددة بنجاح", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addPaymentNavButton_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            GridPrinting.PrintGrid(gridControl1, gridView3, "مخرجات");
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridView3.FindFilterText = txtSearch.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text="";
        }
    }
}
