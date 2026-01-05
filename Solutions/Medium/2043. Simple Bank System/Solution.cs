public class Bank {

    long[] accounts;
    public Bank(long[] balance) {
        accounts = balance;
    }
    
    public bool Transfer(int account1, int account2, long money) {
        int n = accounts.Length;
        if(account1 > n || account2 > n) return false;
        if(accounts[account1 - 1] >= money) {
            accounts[account1 - 1] -= money;
            accounts[account2 - 1] += money;
            return true;
        }
        return false;
    }
    
    public bool Deposit(int account, long money) {
        int n = accounts.Length;
        if(account > n) return false;
        accounts[account - 1] += money;
        return true;
    }
    
    public bool Withdraw(int account, long money) {
        int n = accounts.Length;
        if(account > n || accounts[account - 1] < money) return false;
        accounts[account - 1] -= money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */