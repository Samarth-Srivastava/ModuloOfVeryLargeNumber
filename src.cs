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
        for(int i = 0; i < N; i++){
            ans = ans + (a[i]%p * 1L * pow(10, N-1-i, p))%p;
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