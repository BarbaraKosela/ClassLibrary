﻿using Modelo;
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
    public partial class CadastroAlunos : Form
    {
        private Aluno aluno;
        public CadastroAlunos()
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
                if (aluno == null)
                {
                    aluno = new Aluno();
                }

                aluno.SetNome(txtNome.Text);
                aluno.SetIdade(Convert.ToInt32(txtIdade.Text));
                aluno.SetTurma(txtTurma.Text);
                aluno.SetTurno(txtturno.Text);
                aluno.SetMatricula(Convert.ToInt32(txtMatricula.Text));
                Program.alunos.Add(aluno);
                btnAdicionar.Enabled = true;
                btnApagar.Enabled = true;
                btnEditar.Enabled = true;

            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new CadastroAlunoNota(aluno).ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AtualizarDataGridViewDasNotas();
            }
        }

        private void AtualizarDataGridViewDasNotas()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < aluno.GetNotas().Count(); i++)
            {
                double nota = aluno.GetNotas()[i];
                dataGridView1.Rows.Add(new Object[] { nota });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
