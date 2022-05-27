namespace Dio2.src.Entities
{
    public class Mago : Heroi
    {
        public Mago(
            string nome,
            int level,
            string tipoHeroi,
            int hp,
            int mp) : base(nome, level, tipoHeroi, hp, mp)
        {
        }

        public string Ataque()
        {
            return this.Nome + " Lançou magia";
        }
    }
}