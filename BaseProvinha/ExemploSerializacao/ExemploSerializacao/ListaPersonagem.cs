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


            Tudo tudo = new Tudo();
            tudo.AdicionarPersonagem(personagem);

            BinaryFormatter binaryWritter = new BinaryFormatter();
            Stream stream = new FileStream(ListaPersonagem.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWritter.Serialize(stream, tudo);
            stream.Close();
            MessageBox.Show("Personagem cadastrado com sucesso");
            AtualizarPersonagem();
        }

        private void ListaPersonagem_Activated(object sender, EventArgs e)
        {
            AtualizarPersonagem();
        }

        private void AtualizarPersonagem()
        {
            Tudo tudo = new Tudo();
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
