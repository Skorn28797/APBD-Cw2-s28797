Console.WriteLine("Hello, PJATK!");

int[] numbers = { 1, 2, 3, 4, 10 };

foreach (int n in numbers) {Console.WriteLine("Number: " + n);}

static double CalculateAvarage(int[] numbers)
{
    double sum = 0;
    foreach (var n in numbers) sum += n;
    return sum/numbers.Length;
}
