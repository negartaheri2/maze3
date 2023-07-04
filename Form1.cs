using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void btm0_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
           btnstart.Visible = false;
            btm0.Visible= false;
            pictureBox49.Visible= false;
            if (btnstart.Visible ==false)
            {
                Point p = new Point(-5, -2);
                Cursor.Position = PointToScreen(p);

            }
        }
        

        private void pictureBox45_MouseEnter(object sender, EventArgs e)
        {

            
            Point p = new Point(-5, -2);
            Cursor.Position = PointToScreen(p);


        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            if (btnstart.Visible == false)
            {
                MessageBox.Show("you won");
                btnstart.Text = "RESTART";
                btnstart.Visible = true;


            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
