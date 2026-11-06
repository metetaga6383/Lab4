int[] grades = {75, 90, 45, 60, 85, 30, 95, 70};
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Student {i + 1}: {grades[i]}");
}

CalculateAverage(grades);

static double CalculateAverage(int[] grades)
{
    double sum = 0;
    for (int i = 0;i < grades.Length; i++)
    {
        sum += grades[i];
    }

    double avg = sum / grades.Length;
    Console.WriteLine($"\n\nAverage Grade: {avg:F2}");
    return avg;
}

FindMaximum(grades);


static int FindMaximum(int[] grades)
{
    int max = 0;
    for(int i = 0;i < grades.Length;i++)
    {
        if (grades[i] > max)
        {
            max = grades[i];
        }
    }

    Console.WriteLine($"Highst Grade: {max}");
    return max;
}

FindMinimum(grades);

static int FindMinimum(int[] grades)
{
    int min = 100;
    for(int i = 0;i <grades.Length;i++)
    {
        if(grades[i] < min)
        {
            min = grades[i];
        }
    }

    Console.WriteLine($"Lowest Grade: {min}\n\n");
    return min;
}

Console.WriteLine(CalculateAverage1(70, 90));
Console.WriteLine(CalculateAverage2(60,75,90));
Console.WriteLine(CalculateAverage3(grades));

static double CalculateAverage1(int grade1, int grade2)
{
    return (grade1 + grade2) / 2.0;
}

static double CalculateAverage2(int grade1, int grade2, int grade3)
{
    return (grade1 + grade2 + grade3) / 3.0;
}

static double CalculateAverage3(int[] grades)
{
    double sum = 0;
    for(int i = 0; i < grades.Length; i++)
    {
        sum += grades[i];
    }
    return sum/grades.Length;
}

Console.WriteLine("\n");
Console.WriteLine(CalculateTotal(10, 20));
Console.WriteLine(CalculateTotal(10, 20, 30));
Console.WriteLine(CalculateTotal(grades));
Console.WriteLine(CalculateTotal());
static int CalculateTotal(params int[] grades)
{
    int total = 0;
    for (int i = 0; i < grades.Length; i++)
    {
        total = total + grades[i];
    }
    return total;
}