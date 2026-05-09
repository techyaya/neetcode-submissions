public class Solution {
    public bool IsValid(string s) 
    {
       
        Stack<char> BaliseOuvert = new Stack<char>();
        Dictionary<char,char> dict = new Dictionary<char,char>()
        {
            {')','('},
            {']','['},
            {'}','{'}
        };


        foreach(var x in s)
        {
            if(dict.ContainsKey(x))
            {
                if(BaliseOuvert.Count > 0 && BaliseOuvert.Peek() == dict[x])
                    BaliseOuvert.Pop();
                else 
                    return false;
            }else 
            {
                BaliseOuvert.Push(x);
            }

        }

        return BaliseOuvert.Count ==  0;


    }

    

  
}