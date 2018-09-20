using System;

enum Rating
{
    Good,
    Great,
    Excellent
};
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string dName, float dAge, string dOwner, Rating dRating)
    {
        name = dName;
        age = dAge;
        owner = dOwner;
        rating = dRating;
    }

    public override string ToString()
    {
        return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }
}
