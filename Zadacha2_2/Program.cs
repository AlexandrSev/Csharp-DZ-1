Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
if (A < B) Console.WriteLine($"{B} > {A}");
if (A > B) Console.WriteLine($"{B} < {A}");
if (A == B) Console.WriteLine($"{B} = {A}");
