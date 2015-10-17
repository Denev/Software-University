/*
Write a program that takes as input two integers N and M, and randomizes the numbers between them. Note that M may be smaller than or equal to N.
*/

import java.util.*;

public class _07_RandomizeNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int min = scanner.nextInt();
        int max = scanner.nextInt();

        if (min > max){
            int temp = max;
            max = min;
            min = temp;
        }
        List<Integer> collection = new ArrayList<Integer>();

        for (int i = min; i <= max; i++) {
            collection.add(i);
        }

        Random randomGenerator = new Random();
        Collections.shuffle(collection);
        for (int i = 0; i < collection.size(); i++) {
            System.out.print(collection.get(i) + " ");
        }


    }
}
