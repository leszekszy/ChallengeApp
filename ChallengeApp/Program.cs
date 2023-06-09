int number = 13777799;
string numberInString = number.ToString();
char[] numbersAsChars = numberInString.ToArray();


string[] result = { "0 => ", "1 => ", "2 => ", "3 => ", "4 => ", "5 => ", "6 => ", "7 => ", "8 => ", "9 => " };
int[] result2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

foreach (char c in numbersAsChars)
{
    for (int j = 0; j < 10; j++)
    {
        if (j.ToString() == c.ToString())
        {
            result2[j] += 1;
        }
    }
}

Console.WriteLine("Wyniki dla liczby: " + number);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(result[i] + result2[i]);
}