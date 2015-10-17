/*
Write a program that enters the sides of a rectangle (two integers a and b) and calculates and prints the rectangle's area.
*/

import java.util.Scanner;

public class _01_RectangleArea {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int width = scanner.nextInt();
        int height = scanner.nextInt();
        int area = width * height;

        System.out.println(area);
    }
}
