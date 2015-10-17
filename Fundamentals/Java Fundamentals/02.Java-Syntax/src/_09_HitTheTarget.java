
/*
Write a program that takes as input an integer – the target – and outputs to the console all pairs of numbers between 1 and 20,
which, if added or subtracted, result in the target.
*/

import java.util.Scanner;

public class _09_HitTheTarget {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();

        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j <= 20; j++) {
                if (i + j == number){
                    System.out.printf("\n%d + %d = %d", i, j, number);
                } else if (i - j == number){
                    System.out.printf("\n%d - %d = %d", i, j, number);
                }
            }
        }
    }
}
