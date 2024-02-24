using Zoo.Models.AbstractClass;

namespace Zoo.Models.BirdClass;

internal class Bird : Animal
{
    public Bird(string nickname, int age, string gender, int energy, double price, int mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity)
    {
        _totalBirdPrice += price;
    }

    public override string ToString() => $"Nickname:{Nickname}\nAge:{_Age}\nGender:{_Gender}\nEnergy:{_Energy}\nPrice:{_Price}\nMealQuantity:{_MealQuantity}\n";

    public override void Eat()
    {
        _Energy++;
        if (_MealQuantity <= 0)
            throw new Exception("Max eating Bird");
        else
            _MealQuantity--;
        _Price += 0.5;
        _totalBirdPrice += 0.5;
        _totalEating++;
    }
    public override void Sleep()
    {
        _Energy++;
        if (quantity >= _MealQuantity)
            _MealQuantity++;
    }
    public override void Play()
    {
        if (_Energy <= 0)
        { throw new Exception("Animal must sleep Bird"); }
        _Energy--;
        if (quantity >= _MealQuantity)
            _MealQuantity++;
    }
    public double totalBirdPrice()
    {
        return _totalBirdPrice;
    }
}
