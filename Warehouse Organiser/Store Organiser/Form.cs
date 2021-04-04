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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            inForm frm = new inForm();
            frm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            AllForm frm = new AllForm();
            frm.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            outForm frm = new outForm();
            frm.ShowDialog();
        }

    }
}