
/*
Write a program that converts from a base-7 number to its decimal representation
 */

import java.util.Scanner;

public class _06_Base7ToDecimal {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int numberBaseSeven = scanner.nextInt();
        String numberString = Long.toString(numberBaseSeven);
        System.out.println(Integer.toString(Integer.parseInt(numberString, 7), 10));

    }
}
