namespace Zoo.Models.CatClass;
using Zoo.Models.AbstractClass;

class Cat : Animal
{
    public Cat(string nickname, int age, string gender, int energy, double price, int mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity)
    {
        _totalCatPrice += price;
    }

    public override void Eat()
    {
        _Energy++;
        if (_MealQuantity <= 0)
            throw new Exception("Max eating Cat");
        else
            _MealQuantity--;
        _Price += 2.5;
        _totalCatPrice += 2.5;
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
        { throw new Exception("Animal must sleep Cat"); }
        _Energy--;
        if (quantity >= _MealQuantity)
            _MealQuantity++;
    }

    public override string ToString() => $"Nickname:{Nickname}\nAge:{_Age}\nGender:{_Gender}\nEnergy:{_Energy}\nPrice:{_Price}\nMealQuantity:{_MealQuantity}\n";
    public double totalCatPrice()
    {
        return _totalCatPrice;
    }

}
