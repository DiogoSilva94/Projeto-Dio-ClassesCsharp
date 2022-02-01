namespace RPG.src.Entities
{
    public class WhiteMage : Hero
    {
        public WhiteMage(string HeroName, string HeroType, int Level) : base(HeroName, HeroType, Level)
        {
        }

        public override string Attack()
        {
            return this.HeroName +" Usou Cura Nivel ";
        }
    }
}