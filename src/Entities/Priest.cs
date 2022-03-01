namespace Projeto_RPG_Csharp.src.Entities
{
    public class Priest : Hero
    {
        public Priest(string Name, int Level, string Herotype, int HP, int MP) : base(Name, Level, Herotype, HP, MP)
        {    
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.HP = HP;
            this.MP = MP;        
        }

        public override string Attack()
        {
            return this.Name + " Attacked with Mind Flay";
        }
        public override string Defense()
        {
            return this.Name + " Dodged with Dispersion";
        }

    }
}