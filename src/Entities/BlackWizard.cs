namespace Jogos_em_obj.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype; 
        }

        public string Attack(int bonus)
        {
            return this.Name + " " + "Lançou magia forte de" + bonus ;
        }
        // public override string Attack() 
        // {
        //     return this.Name + " Atacou com espada";
        // }
    }
}