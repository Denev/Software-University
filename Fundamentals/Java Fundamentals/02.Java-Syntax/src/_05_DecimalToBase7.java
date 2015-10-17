/*
Write a program that takes an integer number and converts it to base-7
*/

import java.util.Scanner;

public class _05_DecimalToBase7 {
    public static void main(String[] args) {

        Scanner  scanner= new Scanner(System.in);
        long decimalNumber = scanner.nextLong();
        System.out.println(Long.toString(decimalNumber,7));
    }
}
