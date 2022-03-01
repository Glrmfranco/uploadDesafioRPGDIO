namespace Projeto_RPG_Csharp.src.Entities
{
    public class Paladin : Hero
    {
        public Paladin(string Name, int Level, string Herotype, int HP, int MP) : base(Name, Level, Herotype, HP, MP)
        {    
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.HP = HP;
            this.MP = MP;        
        }

        public override string Attack()
        {
            return this.Name + " Attacked with Divine Storm";
        }
        public override string Defense()
        {
            return this.Name + " Blocked with Divine Shield";
        }

    }
}