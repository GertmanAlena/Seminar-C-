// Задан прямоугольный массив названий и обозначений транспортных средств,
// (a – автомобиль, v – велосипед, m - мотоцикл, p – поезд, s – самолет).
// По введенному обозначению транспортного средства выводится его название

string a = "avtomobile";
string v = "velo";
string m = "moto";
string p = "train";
string s = "plane";
string[] avto = new string[] {a, v, m, p, s};

Console.WriteLine("введите букву транспорта ");
string? arg = Console.ReadLine();

if (arg == "a") Console.Write($"a -> {a} \t");
else if (arg == "v") Console.Write($"v -> {v} \t");
else if (arg == "m") Console.Write($"m -> {m} \t");
else if (arg == "p") Console.Write($"p -> {p} \t");
else if (arg == "s") Console.Write($"s -> {s} \t");
   

else Console.WriteLine($"{arg} -> такого транспорта нет \t");