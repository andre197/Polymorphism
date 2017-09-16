using System;

public class Dog : Animal
{
    public Dog(string name, string favoriteFood)
    {
        base.Name = name;
        base.FavouriteFood = favoriteFood;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}
