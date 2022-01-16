public class Solution {
    public int MyAtoi(string input) {        
        int sign = 1,result = 0, index = 0;
        int n = input.Length;
            
        while (index < n && input[index] == ' ')  
            index++; 
        
        if (index < n && input[index] == '+') 
        {
            sign = 1;
            index++;
        } 
        else if (index < n && input[index] == '-') 
        {
            sign = -1;
            index++;
        }
                
        while (index < n && Char.IsDigit(input[index])) {
            //Minus ASCII Value of 0 from Value to get Actual Number
            int digit = input[index] - '0'; 
            
            if ((result > Int32.MaxValue / 10) || 
                (result == Int32.MaxValue / 10 && digit > Int32.MaxValue % 10)) {     
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }
            
            
            result = 10 * result + digit;
            index++;
        }        
        return sign * result;
    }
}