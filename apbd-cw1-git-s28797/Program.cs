Console.WriteLine("Hello, MAIN CHANGE!");

int[] numbers = { 1, 2, 3, 4, 10 };

foreach (int n in numbers) {Console.WriteLine("Number: " + n);}

static double CalculateAvarage(int[] numbers)
{
    double sum = 0;
    foreach (var n in numbers) sum += n;
    return sum/numbers.Length;
}


static int CalculateMax(int[] numbers)
{
    int max = numbers[0];
    foreach (var n in numbers)
        if (n > max)
            max = n;
    return max;
}
