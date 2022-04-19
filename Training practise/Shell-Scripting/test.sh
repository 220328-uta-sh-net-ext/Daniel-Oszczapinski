#! /usr/bin/bash
using System;

public class Test
{
    public static string secretWord(int N,string S)
    {
        //this is default OUTPUT. You can change it.
        string result;

        //write your logic here:
        
        char[] allLetter = {'a', 'b', 'c', 'd', 'e', 'f' ,'g' , 'h' , 'i' , 'j' , 'k' ,'l' ,'m', 'n', 'o' , 'p' , 'q', 'r' , 's' , 't' , 'u' , 'v' , 'w' , 'x' , 'y' , 'z'  };
        char[] inputStr = StingToCharArray(S);
        for(int i=0; i<N; i++){
           int index =  Array.Indexof(allLetter, inputStr[i]);
           inputStr[i] = allLetter[allLetter.Length-1-index];
        }
        

        result = new string(inputStr);
        return result;
    }
public static char[] StingToCharArray(string strr){
    char[] arr = new char[str.Length];
    if(!String.IsNullOrEmpty(str)){
        for(int i=0; i<str.Length; i++){
            arr[i] = str[i];
        }

    }
    return arr;
}
    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        int N = Convert.ToInt32(Console.ReadLine());
        string S = Console.ReadLine();
        
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(secretWord(N,S));
    }
}
