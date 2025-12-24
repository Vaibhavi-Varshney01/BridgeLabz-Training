import java.util.*;
public class ArmstrongNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int original = n;
        int temp = n;
        int digit = 0;
        double sum = 0;
        while (temp > 0) {
            digit++;
            temp = temp / 10;
        }
        temp = n;
        while (temp > 0) {
            int r = temp % 10;
            sum = sum + Math.pow(r, digit);
            temp = temp / 10;
        }
        if (sum == original) {
            System.out.println("Armstrong Number");
        } else {
            System.out.println("Not an Armstrong Number");
        }
    }
}
