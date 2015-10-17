/*
You are given an array of integers as a single line, separated by a space.
Write a program that checks consecutive pairs and prints if both are odd/even or not.
Note that the array length should also be an even number
*/

import java.util.Scanner;

public class _08_OddAndEvenPairs {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        String[] inputCollection = input.split("\\s+");
        int collection[] = new int[inputCollection.length];
        for (int i = 0; i < inputCollection.length; i++) {
            collection[i] = Integer.parseInt(inputCollection[i]);
        }
        if (collection.length % 2 == 0) {
            for (int i = 0; i < collection.length; i+=2){
                if (collection[i] % 2 == 0 && collection[i + 1] % 2 == 0){
                    System.out.printf("\n%d, %d -> both are even", collection[i], collection[i + 1]);
                } else if(collection[i] % 2 != 0 && collection[i + 1] % 2 != 0){
                    System.out.printf("\n%d, %d -> both are odd", collection[i], collection[i + 1]);
                } else{
                    System.out.printf("\n%d, %d -> different", collection[i], collection[i + 1]);
                }
            }
        } else{
            System.out.println("Invalid length");
        }
    }
}
