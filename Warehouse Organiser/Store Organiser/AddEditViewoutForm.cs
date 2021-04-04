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
    
        
    public partial class AddEditViewoutForm : Form
    {
        public string Mode = "INSERT";
        public int id_out = 0;
        public AddEditViewoutForm()
        {
            InitializeComponent();
        }

        private void navBtnCancel_in_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void AddEditViewoutForm_Load(object sender, EventArgs e)
        {
            this.table_AllTableAdapter.Fill(medDepDataSet.Table_All);
            this.tableOutTableAdapter.Fill(medDepDataSet.TableOut);
            switch(Mode)
            {
                case "INSERT":
                    this.Text = "إضافة";
                    this.tableOutBindingSource.SuspendBinding();
                    this.textBox2.Visible = false;
                    DateDateEdit_out.DateTime = System.DateTime.Today;
                    break;
                case "EDIT":
                    this.Text = "تعديل";
                    this.tableOutTableAdapter.FillByID(medDepDataSet.TableOut, id_out);
                    Name_out_TextBox.Enabled = false;
                    requiredTypelookUpEdit.Visible = false;

                    break;
                case "VIEW":
                    
                    this.Text = "تفاصيل";
                    this.tableOutTableAdapter.FillByID(this.medDepDataSet.TableOut, id_out);
                    this.Therecp_textBox.Enabled = false;
                    Name_out_TextBox.Enabled = false;
                    requiredTypelookUpEdit.Visible = false;
                    Amount_out.Enabled = false;
                    DateDateEdit_out.Enabled = false;
                    notesTextBox_out.Enabled = false;
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
                        
                        this.tableOutTableAdapter.InsertQuery(Therecp_textBox.Text, Convert.ToDouble(requiredTypelookUpEdit.Text), DateDateEdit_out.Text, Name_out_TextBox.Text, Convert.ToDouble(Amount_out.Text), notesTextBox_out.Text);
                        //////
                        int id1 = -1;
                        ///////بعدين مننتقل لجدول الاجمالي و مندور اذا كان السطر موجود قبل منعدل الكمية اذا ماكان موجود منضيف سطر

                        id1 = Convert.ToInt32(this.table_AllTableAdapter.GetByNumberAlband(Convert.ToDouble(requiredTypelookUpEdit.Text)));

                        if (id1 == 0)
                        {
                                MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        if (id1 > 0)
                        {
                            try
                            {
                                double old_amount = (double)(this.table_AllTableAdapter.GetAmountByID(id1));
                                double newamount =  old_amount -(Convert.ToDouble(Amount_out.Text)) ;
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
                        double num_bnd = (double)this.tableOutTableAdapter.GetNumberAlbandById(id_out);
                        try
                        {
                            //////اذا صار تعديل على جدول المدخلات فتغيرت الكمية مسوف يتغير الاجمالي الموجود...
                            double tmp_old_Amount = (double)this.tableOutTableAdapter.GetAmountOutById(id_out);
                            double tmp_new_Amount = Convert.ToDouble(Amount_out.Text);
                            double DIFFERENCE = tmp_new_Amount - tmp_old_Amount;
                            //////نقوم يتطبيق التغير عى جدول الاجمالي

                            ///////الوصول للسطر الموافق في الاجمالي من خلال رقم البند
                            
                            int id2 = Convert.ToInt32(this.table_AllTableAdapter.GetByNumberAlband(num_bnd));
                            ///////

                            //////
                            double Ammount = (double)this.table_AllTableAdapter.GetAmountByID(id2);
                            this.table_AllTableAdapter.UpdateAmountByID(Ammount - DIFFERENCE, id2, id2);
                            //////
                            //Therecp_textBox.Text, Convert.ToDouble(requiredTypelookUpEdit.Text), DateDateEdit_out.Text, Name_out_TextBox.Text, Convert.ToDouble(Amount_out.Text), notesTextBox_out.Text
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                        this.tableOutTableAdapter.UpdateQuery(Therecp_textBox.Text,num_bnd , DateDateEdit_out.Text, Name_out_TextBox.Text, Convert.ToDouble(Amount_out.Text), notesTextBox_out.Text,id_out,id_out);
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
        double old_amount = 0.0;
       

        private void Amount_out_TextChanged(object sender, EventArgs e)
        {
        }

        private void Name_out_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void requiredTypelookUpEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                old_amount = (double)(this.table_AllTableAdapter.GetAmountByID(Convert.ToInt32(requiredTypelookUpEdit.SelectedValue) ));
                labelControl3.Text = "يوجد لديك " + old_amount + " وحدة من هذه المادة ";
                string name = (string)(this.table_AllTableAdapter.GetNameById(Convert.ToInt32(requiredTypelookUpEdit.SelectedValue)));
                Name_out_TextBox.Text = name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث الخطأ التالي في قاعدة البيانات:\n " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
