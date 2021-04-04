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
    public partial class AddEditViewinForm : Form
    {
        public string Mode = "INSERT";
        public int id_in = 0;
        public AddEditViewinForm()
        {
            InitializeComponent();
        }

        private void navBtnCancel_in_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void AddEditViewinForm_Load(object sender, EventArgs e)
        {
            this.table_InTableAdapter.Fill(this.medDepDataSet.Table_In);
            this.table_AllTableAdapter.Fill(medDepDataSet.Table_All);
            switch (Mode)
            {
                case "INSERT":
                    this.Text = "إضافة";
                    this.tableInBindingSource.SuspendBinding();
                    DateDateEdit_in.DateTime = System.DateTime.Today;
                    break;
                case "EDIT":
                    this.Text = "تعديل";
                    this.table_InTableAdapter.FillByID(this.medDepDataSet.Table_In, id_in);
                    Name_in_TextBox.Enabled = false;
                    Number_alband_in.Enabled = false;
                    break;
                case "VIEW":
                    this.Text = "تفاصيل";
                    this.table_InTableAdapter.FillByID(this.medDepDataSet.Table_In, id_in);
                    Name_in_TextBox.Enabled = false;
                    Number_alband_in.Enabled = false;
                    Amount_in.Enabled = false;
                    DateDateEdit_in.Enabled = false;
                    notesTextBox_in.Enabled = false;
                    navBtnSave_in.Visible = false;
                    break;
            }
        }

        private void navBtnSave_in_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {

            switch (Mode)
            {

                case "INSERT":
                    try
                    {

                        ///////نضيف السطر لجدول المدخلات
                        this.table_InTableAdapter.InsertQuery(Convert.ToDouble(Number_alband_in.Text), Name_in_TextBox.Text, DateDateEdit_in.Text, notesTextBox_in.Text, Convert.ToDouble(Amount_in.Text));

                        //////
                        int id1 = -1;
                        ///////بعدين مننتقل لجدول الاجمالي و مندور اذا كان السطر موجود قبل منعدل الكمية اذا ماكان موجود منضيف سطر

                        id1 = Convert.ToInt32(this.table_AllTableAdapter.GetByNumberAlband(Convert.ToDouble(Number_alband_in.Text)));

                        if (id1 == 0)
                        {
                            try
                            {
                                this.table_AllTableAdapter.InsertQuery(Name_in_TextBox.Text, Convert.ToDouble(Number_alband_in.Text), Convert.ToDouble(Amount_in.Text), "");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        if (id1 > 0)
                        {
                            try
                            {
                                double old_amount = (double)(this.table_AllTableAdapter.GetAmountByID(id1));
                                double newamount = (Convert.ToDouble(Amount_in.Text)) + old_amount;
                                this.table_AllTableAdapter.UpdateAmountByID(newamount, id1, id1);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }




                        MessageBox.Show("تمت الإضافة بنجاح", "تمت الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "EDIT":

                    try
                    {

                        //////اذا صار تعديل على جدول المدخلات فتغيرت الكمية مسوف يتغير الاجمالي الموجود...
                        double tmp_old_Amount = (double)this.table_InTableAdapter.GetAmountinById(id_in);
                        double tmp_new_Amount = Convert.ToDouble(Amount_in.Text);
                        double DIFFERENCE = tmp_new_Amount - tmp_old_Amount;
                        //////نقوم يتطبيق التغير عى جدول الاجمالي

                        ///////الوصول للسطر الموافق في الاجمالي من خلال رقم البند
                        double num_bnd = (double)this.table_InTableAdapter.GetNumberAlbandById(id_in);
                        int id2 = Convert.ToInt32(this.table_AllTableAdapter.GetByNumberAlband(num_bnd));
                        ///////

                        //////
                        double Ammount = (double)this.table_AllTableAdapter.GetAmountByID(id2);
                        this.table_AllTableAdapter.UpdateAmountByID(Ammount + DIFFERENCE, id2, id2);
                        //////


                        this.table_InTableAdapter.UpdateQuery(Convert.ToDouble(Number_alband_in.Text), Name_in_TextBox.Text, DateDateEdit_in.Text, notesTextBox_in.Text, Convert.ToDouble(Amount_in.Text), id_in, id_in);
                        MessageBox.Show("تم تعديل البيانات المحددة بنجاح", "تمت الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

            }
        }
    }
}
