namespace AnaPalChallenge
{
    // Write a program in C# to find if given 2 strings are anagrams.
    //anagrams are: danger, garden or dog, god.

    public class Anagram
    {
        public static bool newAnagram(string s1, string s2)
        {
            //if input is empty or null you will get false as an output
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
             return false;
             //if s1 and s2 are not equal print false
            if (s1.Length != s2.Length)
        return false; 
            foreach (char word in s2)
            {
                //returns position of the character of substing
                int i = s1.IndexOf(word);
                if(i>=0)
                    //If greater than or equal to zero remove one element from the string and compare.
                    s1 = s1.Remove(i, 1);
            }
            return string.IsNullOrEmpty(s1);;

       
        }
    }
}
