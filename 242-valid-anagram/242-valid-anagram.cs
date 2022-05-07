public class Solution {
    public bool IsAnagram(string s, string t) {
if (s.Length != t.Length) return false;
            Dictionary<char, int> PairsS = new Dictionary<char, int>();
            Dictionary<char, int> PairsT = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if(!PairsS.TryAdd(s[i], 1))PairsS[s[i]]++;
                if (!PairsT.TryAdd(t[i], 1)) PairsT[t[i]]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                try
                {
                    if (PairsS[t[i]] != PairsT[t[i]])
                    { return false; ; }

                }
                catch (Exception)
                {

                    return false;
                }
            }
            return true;
        }
    }
