/*
You are given n 4-digit numbers. Write a program to find among these numbers all pairs of mirror numbers,
such that the reversed positions of digits in the first number are equal to the positions of digits of the second number.
Note that both numbers should be distinct (a ? b).
Put the sign “<!>” between the numbers. For instance: 1234<!>4321, 6789<!>9876.
*/

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.Scanner;

public class _01_MirrorNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();

        List<String> collection = new ArrayList<String>();
        for (int i = 0; i < number; i++) {
            String input = scanner.next();
            collection.add(input);
        }
        int count = 0;
        List<String> resultCollection = new ArrayList<String>();

        for (int j = 0; j < collection.size(); j++){
            for (int m = 0; m < collection.size(); m++){
                String currentNumber= collection.get(j); //1234
                String reversedNumber = new StringBuffer(collection.get(m)).reverse().toString(); //4321
                if (Objects.equals(currentNumber, reversedNumber)){
                    resultCollection.add(currentNumber);
                    collection.set(j, Integer.toString(count));
                    count++;
                    collection.set(m, Integer.toString(count));
                    count++;

                }
            }
        }

        for (int i = 0; i < resultCollection.size(); i++){

            if (Integer.parseInt(resultCollection.get(i)) < 1000){
                resultCollection.remove(i);
            }

        }

        for (int i = 0; i < resultCollection.size(); i++){

            String currentNumber= resultCollection.get(i); //1234
            String reversedNumber = new StringBuffer(resultCollection.get(i)).reverse().toString();
            if (Objects.equals(currentNumber, reversedNumber)){
                resultCollection.remove(i);
            }
        }
        if (resultCollection.size() > 0) {
            for (int i = 0; i < resultCollection.size(); i++) {
                String reversedNumber = new StringBuffer(resultCollection.get(i)).reverse().toString();
                System.out.println(resultCollection.get(i) + "<!>" + reversedNumber);
            }
        } else{
            System.out.println("No");
        }
    }
        //Output
}

