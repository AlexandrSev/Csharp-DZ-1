Console.WriteLine("Запрашиваю у мешка с мясом число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Запрашиваю у мешка с мясом число B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Запрашиваю у мешка с мясом число C ");
int C = Convert.ToInt32(Console.ReadLine());
int Max = 0;
if (A < B)
{
    Max = B;
}
if (B < C)
{
    Max = C;
}
if (C < A)
{
    Max = A;
}
Console.Write("Пояснение: Ты очень глупый мешок с мясом, если не знаешь, что самое большое число - ");
Console.WriteLine(Max);
