using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyLessons.classe;

namespace MyLessons
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region PlaceHolder
        private void textNameEnter(object sender, EventArgs e)
        {
            if (edtNomeLogin.Text == "Nome")
            {
                edtNomeLogin.Text = "";
                edtNomeLogin.ForeColor = Color.Black;
            }
        }

        private void textNameLeave(object sender, EventArgs e)
        {
            if (edtNomeLogin.Text == "")
            {
                edtNomeLogin.Text = "Nome";
                edtNomeLogin.ForeColor = Color.Silver;
            }
        }

        private void textSenhaEnter(object sender, EventArgs e)
        {
            if (edtSenhaLogin.Text == "Senha")
            {
                edtSenhaLogin.Text = "";
                edtSenhaLogin.ForeColor = Color.Black;
                edtSenhaLogin.UseSystemPasswordChar = true;
            }
        }

        private void textSenhaLeave(object sender, EventArgs e)
        {
            if (edtSenhaLogin.Text == "")
            {
                edtSenhaLogin.Text = "Senha";
                edtSenhaLogin.ForeColor = Color.Silver;
                edtSenhaLogin.UseSystemPasswordChar = false;
            }
        }
        #endregion

        public void btnLogar_Click(object sender, EventArgs e)
        {
            adm adm = new adm(edtNomeLogin.Text, edtSenhaLogin.Text);

            if (adm.VerificarLogin() != true)
            {
                this.Hide();
                frmHome f2 = new frmHome();
                f2.ShowDialog();
            }
            else
            {
                lblErroLogin.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}