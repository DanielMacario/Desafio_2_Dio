using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio2.src.Entities
{
    public class Ninja : Heroi
    {
        public Ninja(string nome,
            int level,
            string tipoHeroi,
            int hp,
            int mp) : base(nome, level, tipoHeroi, hp, mp)
        {
        }

        public string Ataque()
        {
            return this.Nome + " Deu um ataque suspresa e escapou logo em seguida";
        }
    }
}