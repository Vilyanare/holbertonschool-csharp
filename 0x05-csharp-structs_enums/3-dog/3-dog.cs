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
        return "Dog name: " + name + "\nAge: " + age.ToString() + "\nOwner: " + owner + "\nRating: " + rating.ToString();
    }
}
