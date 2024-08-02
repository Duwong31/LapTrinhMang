using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void motionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veevfootToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iconlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?",
                "Thong Bao!", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if(result == DialogResult.Yes)
            
                Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void container_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {

        }

    }
}

