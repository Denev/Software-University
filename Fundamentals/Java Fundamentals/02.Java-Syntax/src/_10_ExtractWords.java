/*
Write a program that extracts words from a string.
Words are sequences of characters that are at least two symbols long and consist only of English alphabet letters. Use regex.
*/

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _10_ExtractWords {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        Pattern regex = Pattern.compile("[a-zA-Z]{2,}+");
        String input = scanner.nextLine();
        Matcher matcher = regex.matcher(input);

        while(matcher.find()) {
            System.out.print(matcher.group() + " ");
        }
    }
}
