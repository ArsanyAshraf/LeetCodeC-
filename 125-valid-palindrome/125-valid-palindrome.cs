public class Solution {
    public bool IsPalindrome(string s) {
       var isPalinrome = new string(s.ToLower().ToCharArray().Where(c =>char.IsLetter(c)||char.IsNumber(c) ).ToArray());

            for (int i = 0; i < isPalinrome.Length; i++)
            {
                if (isPalinrome[i] != isPalinrome[isPalinrome.Length-1-i])
                {
                    return false;
                }
            }


            return true;
    }
}