namespace Jogos_em_obj.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype; 
        }
        // public override string Attack(int bonus) 
        // {
        //     return this.Name + " Lançou Magia";
        // }

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