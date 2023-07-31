// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Three Basic Arrays 
int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

string[] nameArray = { "Tim", "Martin", "Nikki", "Sara" };

bool[] boolArray = new bool[10];
for (int index = 0; index < boolArray.Length; index += 2)
{
    boolArray[index] = true;
}
foreach (bool i in boolArray)
{
    Console.WriteLine(i);
}




// List of Flavors
List<string> flavors = new List<string>();

flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Cookies and Cream");
flavors.Add("Peanut Butter Cup");
flavors.Add("Bubble Gum");


Console.WriteLine(flavors.Count);

Console.WriteLine(flavors[2]);

flavors.RemoveAt(2);

Console.WriteLine(flavors.Count);


// User Dictionary

Dictionary<string, string> users = new Dictionary<string, string>();
Random rand = new Random();

foreach (string name in nameArray)
{
    int randomIndex = rand.Next(flavors.Count);
    string randomFlavors = flavors[randomIndex];
    users.Add(name, randomFlavors);
}
foreach (KeyValuePair<string, string> entry in users)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}



