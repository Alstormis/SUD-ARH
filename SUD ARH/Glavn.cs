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
    public partial class Glavn : Form
    {
        public Glavn()
        {
            InitializeComponent();
        }

        private void Glavn_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // вход в систему
        private void button1_Click(object sender, EventArgs e)
        {
            // хрень не работает
            // открывается какая-то фигня
            Avtoriz l = new Avtoriz();
            l.Show();
            this.Hide();
        }

        // заявка на документ
        private void button2_Click(object sender, EventArgs e)
        {
            Zayavka j = new Zayavka();
            j.Show();
            this.Hide();
        }

        // возможность перемещения
        private void Glavn_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

    // вход в зал
        private void button3_Click(object sender, EventArgs e)
        {
            Cit_zal ci = new Cit_zal();
            ci.Show();
            this.Hide();
        }
    }
}
