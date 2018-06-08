using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSerializacao
{
    [Serializable]
    class PersonagemRepository
    {
        List<Personagem> personagens = new List<Personagem>();
        public PersonagemRepository()
        {
            if (File.Exists("Personagens.bin"))
            
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(ListaPersonagem.NOME_ARQUIVO);
                personagens = ((PersonagemRepository) binaryReader.Deserialize(stream)).ObterPersonagens();
                stream.Close();
            }
        }

        public void AdicionarPersonagem(Personagem personagem)
        {
            personagens.Add(personagem);

            BinaryFormatter binaryWritter = new BinaryFormatter();
            Stream stream = new FileStream(ListaPersonagem.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWritter.Serialize(stream, this);
            stream.Close();
        }

        public List<Personagem> ObterPersonagens()
        {
            return personagens;
        }
    }
}
