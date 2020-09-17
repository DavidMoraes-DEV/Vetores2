using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Aluguel
    {
        public String Nome { get; private set; }
        public String Email { get; private set; }

        public Aluguel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Email;
        }
    }
}
