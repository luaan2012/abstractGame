namespace Jogos_em_obj.src.Entities
{
    public abstract class Hero
    {
        public Hero (string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype; 
        }

        public Hero()
        {

        }
        public string Name;
        public int Level;
        public string HeroType;
        
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

 

        // public string Attack(int bonus)
        // {
        //     return this.Name + " " + "Lançou magia forte de" + bonus ;
        // }
    }
}