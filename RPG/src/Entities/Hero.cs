namespace RPG.src.Entities
{
    

using System;

public abstract class  Hero{
    public string HeroName;
    public string HeroType;
    public int Level;

    public Hero(string HeroName, string HeroType, int Level)
    {
        this.HeroName = HeroName;
        this.HeroType = HeroType;
        this.Level = Level;
    }

    public override  string ToString()
    {
        return this.HeroName + " " + this.HeroType + " " + this.Level;
    }

    public virtual string Attack()
    {
        return this.HeroName + " Atacou";
    }

    public virtual string Defend()
    {
        return this.HeroName + " Defendeu";
    }

    public virtual string Escape()
    {
        return this.HeroName + " Fugiu";
    }
};

}