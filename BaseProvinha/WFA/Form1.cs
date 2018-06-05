using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
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
            try
            {
                Aluno aluno = new Aluno();
                aluno.SetNome(txtNome.Text);
                aluno.SetIdade(Convert.ToInt32(txtIdade.Text));
                aluno.SetTurma(txtTurma.Text);
                aluno.SetTurno(txtturno.Text);
                aluno.SetMatricula(Convert.ToInt32(txtMatricula.Text));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
