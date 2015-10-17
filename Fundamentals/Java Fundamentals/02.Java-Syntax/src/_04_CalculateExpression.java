/*
Write a program that reads three floating point numbers from the console and calculates their result with the following formulae:
((a2 + b2) / (a2 – b2))(a + b + c) / ?c             (a2 + b2 - c3)(a – b)
Then calculate the difference between the average of the three numbers and the average of the two formulae. Average (a, b, c) – Average (f1, f2)
*/

import java.util.Scanner;

public class _04_CalculateExpression {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        double aNumber = scanner.nextDouble();
        double bNumber = scanner.nextDouble();
        double cNumber = scanner.nextDouble();

        double aPowered = Math.pow(aNumber, 2);
        double bPowered = Math.pow(bNumber, 2);
        double cPowered = Math.pow(cNumber, 3);

        double firstPartFirstFormula = (aPowered + bPowered) / (aPowered - bPowered);
        double secondPartFirstFormula = (aNumber + bNumber + cNumber) / Math.sqrt(cNumber);

        double firstPartSecondFormula = aPowered + bPowered - cPowered;
        double secondPartSecondFormula = aNumber - bNumber;

        double firstFormula = Math.pow(firstPartFirstFormula, secondPartFirstFormula);
        double secondFormula = Math.pow(firstPartSecondFormula, secondPartSecondFormula);

        double averageFirst = (aNumber + bNumber + cNumber) / 3;
        double averageSecond = (firstFormula + secondFormula) / 2;
        double averageResult = averageSecond - averageFirst;

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", firstFormula, secondFormula, averageResult);
    }
}
