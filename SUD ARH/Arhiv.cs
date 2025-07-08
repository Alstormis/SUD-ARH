using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUD_ARH
{
    public partial class Arhiv : Form
    {
        public Arhiv()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if(Sidebar.Width == 211)
            {
              
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
            }
            else
            {
                Sidebar.Width = 211;
                SidebarWrapper.Width = 233;
                LineaSidebar.Width = 196;
            }
        }

        private void Arhiv_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accounting1_Load(object sender, EventArgs e)
        {

        }

        private void Acc_Click(object sender, EventArgs e)
        {
            accounting1.BringToFront();
        }

        private void Ygol_Click(object sender, EventArgs e)
        {
            criminal1.BringToFront();
        }

        private void grag_Click(object sender, EventArgs e)
        {
            civil1.BringToFront();
        }

        private void Admini_Click(object sender, EventArgs e)
        {
            administrative1.BringToFront();
        }

        private void mater_Click(object sender, EventArgs e)
        {
            materials1.BringToFront();
        }

        private void apel_Click(object sender, EventArgs e)
        {
            appeal1.BringToFront();
        }

        private void galob_Click(object sender, EventArgs e)
        {
            complaints1.BringToFront();
        }
        private void Arhiv_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
