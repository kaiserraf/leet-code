public class Solution {
    public bool IsPalindrome(int x) {
        int inverso = 0;
        int numOriginal = x;

        while(x > 0){
            int ultimoDigito = x % 10;
            inverso = (inverso * 10) + ultimoDigito;
            x = x / 10;
        }

        if(inverso == numOriginal){
            return true;
        }else{
            return false;
        }
    }
}