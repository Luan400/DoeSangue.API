

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Core.Entities
{

    public class Donor : BaseEntity
    {

      
        public Donor(string nomeCompleto, string email, DateTime dataNascimento, string genero, double peso, string tipoSanguineo, string fatorRh)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            DataNascimento = dataNascimento;
            Genero = genero;
            Peso = peso;
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            Active = true;


        }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Genero { get; set; }

        public double Peso { get; set; }

        public string TipoSanguineo { get; set; }

        public string FatorRh { get; set; }

        public bool Active { get; set; }

        public void Delete(bool active)
        {
            Active = active;
        }


    }




}
