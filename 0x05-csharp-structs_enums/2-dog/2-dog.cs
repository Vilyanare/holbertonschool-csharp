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
}
