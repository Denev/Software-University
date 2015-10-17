/*
Write a program that takes as input an array of strings are prints only the words that start and end with capital letter.
Words are only strings that consist of English alphabet letters. Use regex.
 */

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _11_StartsAndEndWithCapitalLetter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Pattern regex = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b|\\b[A-Z]\\b");

        String input = scanner.nextLine();

        Matcher matcher = regex.matcher(input);
        while(matcher.find()) {
            System.out.print(matcher.group() + " ");
        }
    }
}
