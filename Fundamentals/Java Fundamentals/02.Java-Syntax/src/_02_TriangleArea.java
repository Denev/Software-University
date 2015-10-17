/*
Write a program that enters 3 points in the plane (as integer x and y coordinates),
calculates and prints the area of the triangle composed by these 3 points.
Round the result to a whole number. In case the three points do not form a triangle, print "0" as result.
*/

import java.util.Scanner;

public class _02_TriangleArea {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);


        int aPointX = scanner.nextInt();
        int aPointY = scanner.nextInt();
        int bPointX = scanner.nextInt();
        int bPointY = scanner.nextInt();
        int cPointX = scanner.nextInt();
        int cPointY = scanner.nextInt();

        double area = Math.abs((aPointX * (bPointY - cPointY)
                                + bPointX * (cPointY - aPointY)
                                + cPointX * (aPointY - bPointY))
                                / 2);

        System.out.println((int)area);
    }
}
