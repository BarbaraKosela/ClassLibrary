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
    public partial class CadastroAlunos : Form
    {
        private Aluno aluno;
        private int codigo;
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        public CadastroAlunos(int codigo)
        {
            InitializeComponent();
            
            this.codigo = codigo;
            for (int i = 0; i < Program.alunos.Count(); i++)
            {
                Aluno aluno = Program.alunos[i];
                if (aluno.GetCodigo() == codigo)
                {
                    txtNome.Text = aluno.GetNome();
                    txtIdade.Text = Convert.ToString(aluno.GetIdade());
                    txtTurma.Text = aluno.GetTurma();
                    txtturno.Text = aluno.GetTurno();
                    txtMatricula.Text = Convert.ToString(aluno.GetMatricula());
                    this.aluno = aluno;

                    btnAdicionar.Enabled = true;
                    btnApagar.Enabled = true;
                    btnEditar.Enabled = true;
                    AtualizarDataGridViewDasNotas();
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool novo = aluno == null;
                if (aluno == null)
                {
                    aluno = new Aluno();
                }

                aluno.SetNome(txtNome.Text);
                aluno.SetIdade(Convert.ToInt32(txtIdade.Text));
                aluno.SetTurma(txtTurma.Text);
                aluno.SetTurno(txtturno.Text);
                aluno.SetMatricula(Convert.ToInt32(txtMatricula.Text));

                if (novo)
                {
                Program.alunos.Add(aluno);
                MessageBox.Show("Cadastro realizado com sucesso");

                }

                else
                {
                    for (int i = 0; i < Program.alunos.Count(); i++)
                    {
                        Aluno alunoAux = Program.alunos[i];
                        if (aluno.GetCodigo() == alunoAux.GetCodigo())
                        {
                            Program.alunos[i] = aluno;
                            MessageBox.Show("Alterado com sucesso");
                            return;
                        }
                    }
                }
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
            ChamarCadastroDeNota();
        }

        private void ChamarCadastroDeNota()
        {
            DialogResult dialogResult = new CadastroAlunoNota(aluno).ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AtualizarDataGridViewDasNotas();
                MessageBox.Show("Nota cadastrada com sucesso");
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

        private void CadastroAlunos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5 && aluno != null)
            {
                ChamarCadastroDeNota();
            }
        }

        private void txtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtMatricula != null)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNome != null)
            {
                txtIdade.Focus();
            }
        }

        private void txtIdade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtIdade != null)
            {
                txtturno.Focus();
            }
        }

        private void txtturno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtturno != null)
            {
                txtTurma.Focus();
            }
        }

        private void txtTurma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtTurma != null)
            {
                button1.Focus();
            }
        }
    }
}
