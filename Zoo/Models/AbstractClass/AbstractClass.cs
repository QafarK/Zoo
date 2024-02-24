namespace Zoo.Models.AbstractClass;

abstract class Animal
{
    protected string? _Nickname;
    protected int _Age;
    protected string? _Gender;
    protected int _Energy;
    protected double _Price;
    protected int _MealQuantity;
    protected static int quantity;

    protected static double _totalCatPrice;
    protected static double _totalDogPrice;
    protected static double _totalBirdPrice;
    protected static double _totalFishPrice;

    protected static int _totalEating;
    public string Nickname
    {
        get { return _Nickname!; }
        set
        {
            if (value == null) { _Nickname = "NULL"; return; }
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] <= 90 && value[i] >= 65 || value[i] >= 97 && value[i] <= 122) { }
                else
                {
                    throw new Exception("Nickname must be only alphabets");
                }
            }
            _Nickname = value;
        }
    }
    public string Gender
    {
        get { return _Gender!; }
        set
        {
            if (value == null) { _Gender = "NULL"; }
            else if (value == "Male" || value == "Female")
            {
                _Gender = value;
            }
            else
            {
                throw new Exception("Gender error");
            }
        }
    }
    public Animal(string nickname, int age, string gender, int energy, double price, int mealQuantity)
    {
        Nickname = nickname;
        _Age = age;
        Gender = gender;
        _Price = price;
        _Energy = energy;
        _MealQuantity = mealQuantity;
        quantity = mealQuantity;
    }

    public override string ToString() => $"Nickname:{Nickname}\nAge:{_Age}\nGender:{_Gender}\nEnergy:{_Energy}\nPrice:{_Price}\nMealQuantity:{_MealQuantity}\n";

    public virtual void Eat()
    {
        _Energy++;
        if (_MealQuantity <= 0)
            throw new Exception("Max eating");
        else
            _MealQuantity--;
        _Price += 1.5;
        _totalEating++;
    }
    public virtual void Sleep()
    {
        _Energy++;
        if (quantity >= _MealQuantity)
            _MealQuantity++;
    }
    public virtual void Play()
    {
        if (_Energy <= 0)
        { throw new Exception("Animal must sleep"); }
        _Energy--;
        if (quantity >= _MealQuantity)
            _MealQuantity++;
    }

    public virtual double Price() { return _Price; }
    public int TotalEating() { return _totalEating; }

}
