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
            tudo.AdicionarPersonagem(personagem);

            
            MessageBox.Show("Personagem cadastrado com sucesso");
            AtualizarPersonagem();
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
    }
}
