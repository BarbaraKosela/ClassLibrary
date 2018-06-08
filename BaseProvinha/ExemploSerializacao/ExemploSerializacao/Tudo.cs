using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSerializacao
{
    [Serializable]
    class Tudo
    {
        List<Personagem> personagens = new List<Personagem>();

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
