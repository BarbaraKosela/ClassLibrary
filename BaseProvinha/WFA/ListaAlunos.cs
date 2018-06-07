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
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            new CadastroAlunos().ShowDialog();
        }

        private void ListaAlunos_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                dataGridView1.Rows.Add(new Object[]{
                    aluno.GetCodigo(),
                    aluno.GetNome(),
                    aluno.GetTurma(),
                    aluno.GetTurno(),
                    aluno.GetIdade()

                });
            }
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
           int codigo = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

           new CadastroAlunos(codigo).ShowDialog();
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {

        }
    }
}
