namespace RPG.src.Entities

{
    public class Knigth : Hero
    {
        public Knigth(string HeroName, string HeroType, int Level) : base(HeroName, HeroType, Level)
        {
        }

        public override string Attack(){
           return this.HeroName +" Atacou com a espada";
       }
    }
}