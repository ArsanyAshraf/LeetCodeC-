public class Solution {
    public bool IsAnagram(string s, string t) {
 if (s == null && t == null)
            return true;
        
        if (s == null || t == null)
            return false;
        
        if (s.Length != t.Length)
            return false;
        
        int[] alphabetArray = new int[26];
        
        for (int i = 0; i < s.Length; i++)
        {
            alphabetArray[s[i] - 'a']++;
        }
        
        for (int i = 0; i < t.Length; i++)
        {
            alphabetArray[t[i] - 'a']--;
        }
        
        for (int i = 0; i < alphabetArray.Length; i++)
        {
            if (alphabetArray[i] != 0)
                return false;
        }
        
        return true;
        }
    }
