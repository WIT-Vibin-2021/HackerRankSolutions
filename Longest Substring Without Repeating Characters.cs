public class Solution {
    public int LengthOfLongestSubstring(string s) {
    int n = s.Count();
    int res = 0;
     
    for(int i = 0; i < n; i++)
    {
        bool [] visited = new bool[256];         
        for(int j = i; j < n; j++)
        {
            if (visited[s[j]] == true)
                break;
            else
            {
                res = Math.Max (res, j - i + 1);
                visited[s[j]] = true;
            }
        }
        visited[s[i]] = false;
        
        for (int x=0;x<visited.Count();x++)
            Console.Write(visited[x]+" - ");
    }
    return res;
    }
}