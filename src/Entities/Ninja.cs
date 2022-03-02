namespace Jogos_em_obj.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype; 
        }

        public string Attack(int bonus) 
        {
            if (bonus > 6)
            {
                return this.Name + " Lançou quebra nozes, destruindo o adversário por inteiro";
            }
            else 
            {
                return this.Name + " Lançou uma magia extremamente forte que a deixou vuneravel";
            }
        }
    }
}