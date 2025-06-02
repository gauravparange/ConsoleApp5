// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");




//PrimeNumber();
//Factorial();
//EvenOddNumber();
//FibonicciSeries();
//IsPalindrome();
ReverseString();
//ReverseWords();
//ReverseEachWords();
//CountCharacter();
//RemoveDuplicate();
#region ReverseString
static void ReverseString()
{
    Console.WriteLine("Enter a string to reverse:");
    string input = Console.ReadLine();

    char[] reverseChars = new char[input.Length];
	int reverseIndex = 0;
	for (int i = input.Length - 1; i >= 0; i--)
	{
        reverseChars[reverseIndex] = input[i];
        reverseIndex++;
    }
	Console.WriteLine("Reversing string: " + new string(reverseChars));
   
}
#endregion
#region Palindrome
static void IsPalindrome()
{
    Console.WriteLine("Enter a number to check Palindrome:");
    string input = Console.ReadLine();


    bool isPalindrome = true;
    int left = 0;
    int right = input.Length - 1;

    while (left < right)
    {
        if (input[left] != input[right])
        {
            isPalindrome = false;
            break;
        }
        left++;
        right--;
    }
    Console.WriteLine(input + " is " + (isPalindrome == true ? "Palindrome" : "not a Palindrome"));
    IsPalindrome();
}
#endregion
#region ReverseWord
static void ReverseWords()
{
    Console.WriteLine("Enter the sentence to reverse:");

    string str = Console.ReadLine();

    //string[] chars = input.Split(' ');
    //string result = "";
    //for (int i = chars.Length - 1; i >= 0; i--)
    //{
    //    result += chars[i] + " ";
    //}
    //Console.WriteLine("Reversing sentence: " + result);

    string result = "";
    string word = "";
    for(int i = str.Length - 1;i >= 0; i--)
    {
        if (str[i] != ' ')
        {
            word = word + str[i]  ;
        }
        else
        {
            if(word.Length>0)
            {
                result += word + " ";
                word = "";
            }
        }
    }
    if(word.Length > 0)
    {
        result += word;
    }

    Console.WriteLine(result);



    ReverseWords();
    //string word = "";
    //string result = "";

    //for(int i = input.Length - 1;i >= 0;i--)
    //{
    //    if (input[i] == ' ')
    //    {
    //        word = input[i] + word;
    //    }
    //    else
    //    {
    //        if(word.Length > 0)
    //        {
    //            result += word + " ";
    //            word = "";
    //        }
    //    }

    //}

}
#endregion

static void ReverseEachWords()
{
    Console.WriteLine("Enter the sentence to reverse:");

    string str = Console.ReadLine();

    string result = "";
    string word = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
        {
            word = str[i] + word;
        }
        else
        {
            if (word.Length > 0)
            {
                result += word + " ";
                word = "";
            }
        }
    }
    if (word.Length > 0)
    {
        result += word;
    }

    Console.WriteLine(result);
}

static void CountCharacter()
{
    Console.WriteLine("Enter the characters to count:");

    string str = Console.ReadLine();
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach(var c in str)
    {
        if(charCount.ContainsKey(c))
        {
            charCount[c]++;
        }
        else
        {
            charCount[c] = 1;
        }
    }
    foreach (var item in charCount)
    {
        Console.WriteLine($"'{item.Key}' : {item.Value}");
    }

}
static void RemoveDuplicate()
{
    Console.WriteLine("Enter the string to remove Duplicate:");

    string str = Console.ReadLine();

    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (!result.Contains(str[i]))
        {
            result += str[i];
        }
    }
    Console.WriteLine("Result:" + result);
    RemoveDuplicate();
}

static void PrimeNumber()
{
    Console.WriteLine("Enter the number:");

    int n = Convert.ToInt32(Console.ReadLine());
    bool isPrime = true;
    if (n <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
    Console.WriteLine(n + " is a " + (isPrime ? "Prime Number" : "Not a Prime Number"));
    PrimeNumber();
}

static void EvenOddNumber()
{

    Console.WriteLine("Enter the number:");

    int n = Convert.ToInt32(Console.ReadLine());

    if(n % 2 == 0)
    {
        Console.WriteLine("Even Number");
    }
    else
    {
        Console.WriteLine("Odd Number");
    }
    EvenOddNumber();
}
static void FibonicciSeries()
{
    Console.WriteLine("Enter the length to print fibonicci series:");

    int n = Convert.ToInt32(Console.ReadLine());

    int first = 0, second = 1, last;
    Console.Write(first + " " + second + " ");
    for (int i = 2; i < n; i++)
    {
        last = first + second;
        Console.Write(last + " ");
        first = second;
        second = last;
    }
}

static void Factorial()
{
    Console.WriteLine("Enter the number:");

    int n = Convert.ToInt32(Console.ReadLine());
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }

    Console.WriteLine(result);

}

