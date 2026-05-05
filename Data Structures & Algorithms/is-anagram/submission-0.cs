public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
            return false;

        char[] s_arr = s.ToCharArray();
        Array.Sort(s_arr);
        s = new string(s_arr);

        char[] t_arr = t.ToCharArray();
        Array.Sort(t_arr);
        t = new string(t_arr);

        if(string.Equals(s,t))
            return true;
        else 
            return false;
}

   

}
