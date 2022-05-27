namespace Dio2.src.Entities
{
    public abstract class Heroi
    {
        public Heroi(string nome, int level, string tipoHeroi, int hp, int mp)
        {
            this.Nome = nome;
            this.Level = level;
            this.TipoHeroi = tipoHeroi;
            this.Hp = hp;
            this.Mp = mp;
        }
        public string Nome;
        public int Level;
        public string TipoHeroi;
        public int Hp;
        public int Mp;

        public override string ToString()
        {
            return this.Nome + " Level = " + this.Level + " Classe = " + this.TipoHeroi + " Vida = " + this.Hp + " Mana = " + this.Mp;
        }

        /*  public virtual string Ataque()
         {
             return this.Nome + " Atacou com a espada";
         } */

    }
}