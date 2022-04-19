global using System;
using AnaPalChallenge;
Console.Write("Please enter your first word: ");
var x = Console.ReadLine();
Console.Write("Please enter your second word: ");
 var y = Console.ReadLine();
//Anagram.newAnagram();
x = x.ToLower();
y = y.ToLower();
var result = Anagram.newAnagram(y,x);
Console.WriteLine($"{x} and {y} = {result}");
 //string s1 = Console.ReadLine();
 // string s2 = Console.ReadLine();
//Console.WriteLine(ReAnagram(s1,s2));

//Console.Write("Please enter your first word: ");
//var x = Console.ReadLine();
//Console.Write("Please enter your second word: ");
//var y = Console.ReadLine();
/*static bool polindromCheck(string s)
{
    s = s.ToLower;
    var sArray = s.ToCharArray();
    int words = 0;
    for(int i=s.Lenght-1; i>=0; i--)
    {
        aArray[j++] = s[i];
    }
    string rev = new string(array);

}

Console.Write("please enter first string: ");
String firStstring = Console.ReadLine();

Console.Write("please enter second string: ");
String secString = Console.ReadLine();
if (polindromCheck(firStstring == secString))
{
    Console.WriteLine($"{firstString} and {secString} are a palindrome!");
}
else{
    onsole.WriteLine("nope");
}*/
/*
static bool polindromCheck(string s)
{
    s = s.ToLower();
    var sArray = new char[s.Length];
    int j = 0;
    for (int i = s.Length - 1; i >= 0; i--)
    {
        sArray[j++] = s[i];
        
    }
    string rev = new string(sArray);
    bool areEqual = sArray.SequenceEqual(rev);
    
    return true;

}

Console.Write("please enter first string: ");
String firstString = Console.ReadLine();

if (polindromCheck(firstString))
{
    Console.WriteLine($"{firstString} are a palindrome!");
}
else
{
    Console.WriteLine("nope");
}
*/