
public class Solution {
    public bool IsPalindrome(string s) 
    {
        s = string.Concat(s.Where(Char.IsLetterOrDigit));

        int i = 0;
        int j = s.Length -1;
        int x = 0;

        while(i < j)
        {
            if(Char.ToUpper(s[i]) == char.ToUpper(s[j]))
            {
                x++;
            }else 
            {
                return false;
            }

            i++;
            j--;
        }

        int val = (s.Length) / 2 ;
        return x == val ? true : false;

    }
}
