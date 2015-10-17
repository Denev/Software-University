/*
Create a method that takes two strings as arguments and returns the sum of their character codes multiplied
(multiply str1.charAt (0) with str2.charAt (0) and add to the total sum).
Then continue with the next two characters. If one of the strings is longer than the other,
add the remaining character codes to the total sum without multiplication.
*/

import java.util.Scanner;

public class _12_CharacterMultiplier {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String firstInput = scanner.next();
        String secondInput = scanner.next();
        characterMultiplier(firstInput, secondInput);
    }
    public static void characterMultiplier(String firstInput, String secondInput){
        boolean isDifferentLengthFirst = false;
        boolean isDifferentLengthSecond = false;

        String keepFirstInput = firstInput;
        String keepSecondInput = secondInput;

        if (firstInput.length() != secondInput.length()){

            if (firstInput.length() > secondInput.length()){
                secondInput = String.format("%-"+firstInput.length()+"s", secondInput);
                isDifferentLengthFirst = true;
            } else {
                firstInput = String.format("%-"+secondInput.length()+"s", firstInput);
                isDifferentLengthSecond = true;
            }
        }
        int sum = 0;
        for (int i = 0; i < firstInput.length(); i++) {
            sum += firstInput.charAt(i) * secondInput.charAt(i);
        }
        int start = Math.abs(firstInput.length() - secondInput.length());
        if (isDifferentLengthFirst){
            for (int i = keepSecondInput.length(); i < firstInput.length(); i++) {
                sum -= 32 * keepFirstInput.charAt(i);
                sum+= firstInput.charAt(i);
            }
        } else if (isDifferentLengthSecond){
            for (int i = keepFirstInput.length(); i < secondInput.length(); i++) {
                sum -= 32 * keepSecondInput.charAt(i);
                sum+= secondInput.charAt(i);
            }
        }
        System.out.println(sum);
    }
}

