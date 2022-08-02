int[] numArray = {1,2,3,4,5,6,7,8,9};


string[] users = new string[] {"Piccolo", "Boneface", "Banksy", "Shephard Fairey", "Charles Burns", "Adrian Tomine"};


bool[] alternating = new bool[10] {true, false, true, false, true, false, true, false, true, false};

for(int n = 0; n < alternating.Length; n++)
{
    Console.WriteLine($"The answer is {alternating[n]}");
}

List<string> flavors = new List<string>() {
    "pistachio",
    "green tea",
    "ube",
    "barley",
    "toffee",
    "mint chocolate chip",
    "half baked",
    "spumoni",
    "bourbon persimmon",
    "cookies & cream",
    "whiskey custard",
    "coffee"
};

flavors.Add("guava sorbet");

Console.WriteLine(flavors.Count);

Console.WriteLine(flavors[2]);
flavors.RemoveAt(3);
Console.WriteLine(flavors.Count);

foreach (string flavor in flavors)
{
    Console.WriteLine(flavor);
}

Random rand = new Random();

Dictionary<string, string> favoriteFlavors = new Dictionary<string, string>() {
    {"name", "favorite_flavor"}
};

for (int i = 0; i < users.Length; i++)
{
    favoriteFlavors.Add(users[i], flavors[rand.Next(flavors.Count)]);
}


foreach (KeyValuePair<string, string> entry in favoriteFlavors)
{
    Console.WriteLine($"Key: {entry.Key} - Value: {entry.Value}");
}
