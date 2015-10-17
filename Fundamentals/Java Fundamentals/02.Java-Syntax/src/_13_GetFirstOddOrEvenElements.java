/*
Write a method that returns the first N odd/even elements from a collection. Return as many as you can.
*/

import java.util.Arrays;
import java.util.Scanner;

public class _13_GetFirstOddOrEvenElements {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        String command = scanner.nextLine();

        output(input, command);
    }
    public static void output(String input, String command){
        String[] inputCollection = input.split(" ");
        String[] commandCollection = command.split(" ");
        int times = Integer.parseInt(commandCollection[1]);

        for (int i = 0; i < inputCollection.length; i++) {
            int currentNumber = Integer.parseInt(inputCollection[i]);
                if (Arrays.asList(commandCollection).contains("odd")){
                    if (currentNumber % 2 != 0){
                        System.out.print(currentNumber + " ");
                    }
                }
                else{
                    if (currentNumber % 2 == 0){
                        System.out.print(currentNumber + " ");
                    }
                }
        }
    }
}
