using Zoo.Models.CatClass;
using Zoo.Models.DogClass;
using Zoo.Models.BirdClass;
using Zoo.Models.FishClass;
using Zoo.Models.AbstractClass;



Console.WriteLine();

Cat cat = new("Cat", 5, "Male", 3, 10.5, 4);
Cat cat2 = new("Tom", 7, "Male", 4, 6.5, 5);
cat.Eat();
cat.Sleep();
cat.Play();
cat.Eat();
cat.Play();
cat.Play();
cat.Play();

List<Cat> list_cat = new List<Cat>();
List<Dog> list_dog = new List<Dog>();
List<Bird> list_bird = new List<Bird>();
List<Fish> list_fish = new List<Fish>();
list_cat.Add(cat);
list_cat.Add(cat2);
double CatTotalyPrice;
double DogTotalyPrice;
double BirdTotalyPrice;
double FishTotalyPrice;

RemoveByNickName_cat("Tom");
foreach (var item in list_cat)
{
    Console.WriteLine(item.Nickname);
}
Console.WriteLine("----");
Console.WriteLine(CatTotalyPrice);
Console.WriteLine(cat.totalCatPrice());
Console.WriteLine("Total eating:"+list_cat[0].TotalEating());

void RemoveByNickName_cat(string nickname)
{
    if (list_cat == null) { throw new Exception("Cat is NULL"); }
    CatTotalyPrice = list_cat[0].totalCatPrice();
    bool deleted = false;
    foreach (var item in list_cat)
    {
        if (item.Nickname == nickname)
        {
            CatTotalyPrice -= item.Price();
            list_cat.Remove(item);
            deleted = true;
            break;
        }
    }
    if (deleted == false)
    {
        throw new Exception(nickname + " Not Founded");
    }
}

void RemoveByNickName_dog(string nickname)
{
    if (list_dog == null) { throw new Exception("Dog is NULL"); }
    DogTotalyPrice = list_dog[0].totalDogPrice();
    bool deleted = false;
    foreach (var item in list_dog)
    {
        if (item.Nickname == nickname)
        {
            DogTotalyPrice -= item.Price();
            list_dog.Remove(item);
            deleted = true;
            break;
        }
    }
    if (deleted == false)
    {
        throw new Exception(nickname + " Not Founded");
    }
}

void RemoveByNickName_bird(string nickname)
{
    if (list_bird == null) { throw new Exception("Bird is NULL"); }
    BirdTotalyPrice = list_bird[0].totalBirdPrice();
    bool deleted = false;
    foreach (var item in list_bird)
    {
        if (item.Nickname == nickname)
        {
            BirdTotalyPrice -= item.Price();
            list_bird.Remove(item);
            deleted = true;
            break;
        }
    }
    if (deleted == false)
    {
        throw new Exception(nickname + " Not Founded");
    }
}

void RemoveByNickName_fish(string nickname)
{
    if (list_fish == null) { throw new Exception("Fish is NULL"); }
    FishTotalyPrice = list_fish[0].totalFishPrice();
    bool deleted = false;
    foreach (var item in list_fish)
    {
        if (item.Nickname == nickname)
        {
            FishTotalyPrice -= item.Price();
            list_fish.Remove(item);
            deleted = true;
            break;
        }
    }
    if (deleted == false)
    {
        throw new Exception(nickname + " Not Founded");
    }
}