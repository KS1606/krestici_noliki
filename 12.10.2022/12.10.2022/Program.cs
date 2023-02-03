using _12._10._2022;

pizza margarita = new pizza();
margarita.Name = "Маргарита";
margarita.Diametr = 28;


pizza havai = new pizza();
havai.Name = "Гавайская";
havai.Diametr = 30;

List<pizza> menu = new List<pizza>();
menu.Add(margarita);
menu.Add(havai);

foreach (pizza pizza in menu)
{
    Console.WriteLine(pizza.Name);
    Console.WriteLine(pizza.Diametr);
}

