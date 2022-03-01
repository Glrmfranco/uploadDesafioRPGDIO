namespace Projeto_RPG_Csharp.src.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string Name, int Level, string Herotype, int HP, int MP) : base(Name, Level, Herotype, HP, MP)
        {    
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.HP = HP;
            this.MP = MP;        
        }

        public override string Attack()
        {
            return this.Name + " Attack with Heroic Strike";
        }
        public override string Defense()
        {
            return this.Name + " Blocked with Shield Wall";
        }

    }
}