Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

bool IsPalindrome (int a)
{
    int b = (((a/1000)%10)*10) + a/10000;
    int c = a%100;
    if (b == c) return true;
    else return false;
}
if (IsPalindrome(number) == true) Console.WriteLine("Да");
else Console.WriteLine("Нет");

// Console.WriteLine("Введите число: ");
// string str = Console.ReadLine();
// char[] removeMinus = {'-'};
// string positiveStr = str.TrimStart(removeMinus);

// bool IsPalindrome(string s)
// {
//     if (s[0] == s[4] && s[1] == s[3]) return true;
//     else return false;
// }
// if (IsPalindrome(positiveStr) == true) Console.WriteLine("Да");
// else Console.WriteLine("Нет");