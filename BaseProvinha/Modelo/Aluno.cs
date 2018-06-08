using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Aluno
    {
        private static int UltimoCodigo;
        private int Codigo;
        private string Nome;
        private int Idade;
        private string Turno;
        private string Turma;
        private int Matricula;
        private List<double> Notas = new List<double>();

        public Aluno()
        {
            Codigo = ++UltimoCodigo;
        }
        public int GetCodigo()
        {
            return Codigo;
        }
        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter no mínimo 3 caracteres");
            }
            
            if (nome.Trim().Count() > 100)
            {
                throw new Exception("Nome deve conter no máximo 100 caracteres");
            }

            
            Nome = nome;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetIdade(int idade)
        {

            if (idade < 4)
            {
                throw new Exception("Idade deve ser no mínimo maior do que 4 anos");
            }

            if (idade > 23)
            {
                throw new Exception("Idade deve ser menor do que 23 anos");
            }
            Idade = idade;
        }

        public int GetIdade()
        {
            return Idade;
        }


        public void SetTurno(string turno)
        {
            if (turno.Trim()== "")
            {
                throw new Exception("Seu turno deve conter no mínimo 7 caracteres");
            }

            if (turno.Trim().ToLower() != "matutino" && turno.Trim().ToLower() != "vespertino" && turno.Trim().ToLower() != "noturno")
            {
                throw new Exception("Turno deve conter somente matutino, vespertino ou noturno");
            }
            
               
                Turno = turno;

        }

        public string GetTurno()
        {
            return Turno;
        }

        public void SetTurma(string turma)
        {
            if (turma.Trim().Count() < 1)
            {
                throw new Exception("A turma deve ser maior do que 1");
            }

            if (turma.Trim().Count() > 3)
            {
                throw new Exception("Turma deve conter no máximo 3");
            }
            Turma = turma;
        }

        public string GetTurma()
        {
            return Turma;
        }

        public void SetMatricula(int matricula)
        {
            if (matricula < 0)
            {
                throw new Exception("A matricula deve ser maior do que 0");

            }


            Matricula = matricula;
        }

        public int GetMatricula()
        {
            return Matricula;
        }

        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }

        public List<double> GetNotas()
        {
            return Notas;
        }
    }
}
