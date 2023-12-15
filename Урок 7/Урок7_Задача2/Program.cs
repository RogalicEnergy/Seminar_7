/* Задача 2 */

public class Solution {
public static int A(int m, int n) {
    if (m == 0) {
        return n + 1;
    } 
    else if (n == 0 && m > 0) {
        return A(m - 1, 1);
    }
    else {
        return A(m - 1, A(m, n - 1));
    }
    }
public static void Main(String[] args) {
    System.Console.WriteLine(A(3, 2));
}
}
