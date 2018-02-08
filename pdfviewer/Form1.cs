using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfviewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog var = new OpenFileDialog() { ValidateNames = true,InitialDirectory= "f:\\", Multiselect = false, Filter = "PDF|*.pdf" })
            {
                if(var.ShowDialog()== DialogResult.OK)
                {
                    axAcroPDF1.src = var.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
