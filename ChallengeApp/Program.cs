// See https://aka.ms/new-console-template for more information

int number = 701789;
List<int> digits = new List<int>();

for (int i = 0; i < 10; i++)
{
    digits.Add(0);
}

string numberAsString = number.ToString();
char[] numberAsChararray = numberAsString.ToCharArray();

for (int i = 0; i < numberAsChararray.Length; i++)
{
    int j = Convert.ToInt32(numberAsChararray[i]) - 48;
    int k = digits[j];
    digits[j] = ++k;
}

Console.WriteLine("Wyniki dla liczby: " + number);

int ii = 0;
foreach (var digit in digits)
{
    Console.WriteLine(ii++ + " => " + digit);
}
