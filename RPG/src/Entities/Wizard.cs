namespace RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string HeroName, string HeroType, int Level) : base(HeroName, HeroType, Level)
        {
        }


        public override string Attack()
        {
            return this.HeroName + " Atacou com Bola de Fogo";
        }
    }
}