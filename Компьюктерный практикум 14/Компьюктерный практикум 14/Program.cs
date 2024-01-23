Console.WriteLine("Введите сумму вклада");
decimal a = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите кол-во месяцев");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= b)
{
    a += a * 0.07m;
    i += 1;
}
Console.WriteLine($"Сумма по окончанию вашего вклада составит:{a}");