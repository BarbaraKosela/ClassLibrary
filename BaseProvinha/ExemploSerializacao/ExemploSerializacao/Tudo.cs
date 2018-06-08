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
    class Tudo
    {
        List<Personagem> personagens = new List<Personagem>();
        public Tudo()
        {
            if (File.Exists("Personagens.bin"))
            
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead("Personagens.Bin");
                personagens = ((Tudo) binaryReader.Deserialize(stream)).ObterPersonagens();
                stream.Close();
            }
        }

        public void AdicionarPersonagem(Personagem personagem)
        {
            personagens.Add(personagem);
        }

        public List<Personagem> ObterPersonagens()
        {
            return personagens;
        }
    }
}
