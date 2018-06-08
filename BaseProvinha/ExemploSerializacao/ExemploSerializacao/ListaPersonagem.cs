using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSerializacao
{
    public partial class ListaPersonagem : Form
    {
        public int posicao = -1;
    public static string NOME_ARQUIVO = "Personagens.bin";
        public ListaPersonagem()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Personagem personagem = new Personagem();
            personagem.SetNome(txtNome.Text);
            personagem.SetNivelChakra(Convert.ToInt32(txtNivelChakra.Text));
            personagem.SetCla(cbCla.SelectedItem.ToString());


            PersonagemRepository tudo = new PersonagemRepository();
            
            if (posicao == -1)
            {
                tudo.AdicionarPersonagem(personagem);
                MessageBox.Show("Personagem cadastrado com sucesso");
            }
            else
            {
                tudo.EditarPersonagem(personagem, posicao);
                MessageBox.Show("Personagem alterado com sucesso");
            }

            LimparCampos();
            AtualizarPersonagem();
            
            
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtNivelChakra.Text = "";
            cbCla.SelectedIndex = -1;
            posicao = -1;
        }

        private void ListaPersonagem_Activated(object sender, EventArgs e)
        {
            AtualizarPersonagem();
        }

        private void AtualizarPersonagem()
        {
            PersonagemRepository tudo = new PersonagemRepository();
            dataGridView1.Rows.Clear();
            foreach (Personagem personagem in tudo.ObterPersonagens())
            {
                dataGridView1.Rows.Add(new Object[]{
                
                personagem.GetNome(),
                personagem.GetCla(),
                personagem.GetNivelChakra()
                });
            }
        }

        private void btnSalvar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ListaPersonagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.L || e.KeyCode == Keys.E))
            {
                ApagarPersonagem();
            }

            else if (e.KeyCode == Keys.F2)
            {
                EditarPersonagem();
            }
        }

        private void EditarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo nesta lista");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            PersonagemRepository repository = new PersonagemRepository();
            int quantidade = 0;
            foreach (Personagem personagem in repository.ObterPersonagens())
            {
                if (personagem.GetNome() == nome)
                {
                    txtNome.Text = personagem.GetNome();
                    txtNivelChakra.Text = Convert.ToString(personagem.GetNivelChakra());
                    cbCla.SelectedItem = personagem.GetCla();
                    posicao = quantidade;
                    return;
                }
                quantidade ++;
            }
        }

        private void ApagarPersonagem()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo nesta lista");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            PersonagemRepository repository = new PersonagemRepository();
            repository.ApagarPersonagem(nome);
            MessageBox.Show(nome + " apagado com sucesso");
            LimparCampos();
        }

        private void ListaPersonagem_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            EditarPersonagem();
        }
    }
}
