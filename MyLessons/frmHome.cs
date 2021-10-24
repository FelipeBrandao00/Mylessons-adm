using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyLessons
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        #region Dll import
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region Edition windows
        private void AbrirForm(object formTelas)
        {
            if (this.pnlInicial.Controls.Count > 0)
            {
                this.pnlInicial.Controls.RemoveAt(0);
            }
            Form ft = formTelas as Form;
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            this.pnlInicial.Controls.Add(ft);
            this.pnlInicial.Tag = ft;
            ft.Show();
        }
        #endregion

        #region Selected Button (não sei se dá para simplificar)
        public void ButtonColorBlock(object btnSelected)
        {
            Button bs = btnSelected as Button;
            btnPremio.ForeColor = Color.White;
            btnPremio.Enabled = true;

            btnRanking.ForeColor = Color.White;
            btnRanking.Enabled = true;

            btnTurma.ForeColor = Color.White;
            btnTurma.Enabled = true;

            btnProfessores.ForeColor = Color.White;
            btnProfessores.Enabled = true;

            bs.ForeColor = Color.Black;
            bs.Enabled = false;
        }
        #endregion

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fL = new frmLogin();
            fL.Show();
        }
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Top buttons

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmProfessores());
            ButtonColorBlock(btnProfessores);
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmTurmas());
            ButtonColorBlock(btnTurma);
        }

        private void frmHome_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            frmLogin fL = new frmLogin();
            fL.Show();

        }

        private void btnPremio_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmPremios());
            ButtonColorBlock(btnPremio);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmRanking());
            ButtonColorBlock(btnRanking);
        }

        #endregion
    }
}
