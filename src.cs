class Solution {
    public void solve() {
        List<int> a = new List<int>();
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        a.Add(3);
        a.Add(2);
        a.Add(4);
        a.Add(6);
        a.Add(4);
        int p = 100000;
        int N = 100;
        long ans = 0;
        //O(n2)
        for(int i = 0; i < N; i++){
            ans = ans + (a[i]%p * 1L * pow(10, N-1-i, p))%p;
            ans = ans%p; //adding all the remainders can result in overflow, to avoid that take modulo
        }
        
        //O(n) 
        //calculating power of 10 on every step, instead start from right where 10^0 = 1 and multiply 10 on each step going from right to left
        //carry forward
        int exp = 1;
        for(int i = N-1; i >= 0; i--){
            ans = ans + (a[i] * exp)%p;
            ans = ans%p;
            exp = (exp*10)%p;
        }
        Console.WriteLine(ans%p);
    }

    public long pow(int a, int b, int p){
        long prod = 1;
        for(int i  = 0; i < b; i++){
            prod = (prod%p * a%p)%p;
        }
        return prod;
    }
}
