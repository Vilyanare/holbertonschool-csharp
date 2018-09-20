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
        return string.Format("Dog name: {1}{0}Age: {2}{0}Owner: {3}{0}Rating: {4}", Environment.NewLine, name, age, owner, rating);
    }
}
