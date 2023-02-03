

List <string> garderob2 = new List<string>() { "красноя куртка", "желтая куртка", "черная куртка" };
Console.WriteLine(garderob2[2]);
garderob2.Add("синяя");
Console.WriteLine(garderob2[3]);
garderob2.Remove("синяя");
garderob2.RemoveAt(0);



string[] massiv;
massiv = new string[10];


string[] garderob = new string[3] {"красноя куртка" , "желтая куртка" , "черная куртка"};
Console.WriteLine(garderob[0]);
Console.WriteLine(garderob[1]);
Console.WriteLine(garderob[2]);

garderob[2] = "фиолетовая";

for (int i=0; i < garderob.Length;i++)
{
    Console.WriteLine(garderob[i]);
}



foreach (string curtka in garderob)
{
    Console.WriteLine(curtka);
}



string[] garderob = new string[3] { "красноя куртка", "желтая куртка", "черная куртка" };

string[,] garderobMatrix = new string[2, 3] {{ "красноя куртка", "желтая куртка", "черная куртка" } , { "красноя куртка", "желтая куртка", "черная куртка" }};
Console.WriteLine(garderobMatrix[1, 0]);