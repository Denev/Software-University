import java.util.Scanner;

/*
Create a Java program that reads a number N from the console and calculates the sum of all numbers from 1 to N (inclusive).
*/

public class _06_SumNumbersFromOneToN {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int length = scanner.nextInt();
        int sum = 0;
        for (int i = 1; i <= length; i++){
            sum += i;
        }
        System.out.println(sum);
    }
}
