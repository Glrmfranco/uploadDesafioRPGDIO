namespace Projeto_RPG_Csharp.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string Herotype, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;
            this.HP = HP;
            this.MP = MP;
        }
        public string Name;
        public int Level;
        public string Herotype;
        public int HP;
        public int MP;


        public override string ToString()
        {
            return "You choose: " + this.Name + " Level: " + this.Level + " Class: " + this.Herotype + " Life: " + this.HP + " Mana: " + this.MP;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou ";
        }
        public virtual string Defense()
        {
            return this.Name + " Bloqueou ";
        }
    }
}