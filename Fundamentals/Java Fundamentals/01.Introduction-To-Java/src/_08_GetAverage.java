import java.util.Scanner;

/*
Create a method that finds the average of three numbers. Read in internet about java methods. Check the naming conventions.
Invoke your method and test it. Format the output to two digits after the decimal separator. The placeholder is %.2f
*/
public class _08_GetAverage {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double firstNumber = scanner.nextDouble();
        double secondNumber = scanner.nextDouble();
        double thirdNumber = scanner.nextDouble();

        getAverage(firstNumber, secondNumber, thirdNumber);
    }

    public static void getAverage(double firstNumber, double secondNumber, double thirdNumber){

        double average = (firstNumber + secondNumber + thirdNumber) / 3;

        System.out.printf("%.2f", average);
    }
}
