/*
Write a program that reads a list of words from the file words.txt and finds the count of vowels (гласни букви),
consonants (съгласни) and other punctuation marks. Since English is a bit tricky, assume that a, e, i, o, u are vowels and all others are consonants.
Punctuation marks are (!,.?). Do not count whitespace.
Write the results in file count-chars.txt.
*/

import java.io.*;

public class _03_CountCharacterTypes {
    public static void main(String[] args) {
        File readFile = new File("resources/_03_CountCharacterTypesResources/words");
        File writeFile = new File("resources/_03_CountCharacterTypesResources/count-chars");
        try {
            BufferedReader bfr = new BufferedReader(new FileReader(readFile));
            FileWriter fw = new FileWriter(writeFile, false);
            PrintWriter writer = new PrintWriter(fw, true);
            String line = bfr.readLine();
            int vowelCount = 0;
            int consonantCount = 0;
            int punctuationCount = 0;
            while(line != null){
                for (int i = 0; i < line.length(); i++) {
                    char currentSymbol = line.charAt(i);
                    boolean isVowel = "aeiouAEIOU".indexOf(currentSymbol) >= 0;
                    boolean isConsonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMPQRSTVWXYZ".indexOf(currentSymbol) >= 0;
                    boolean isPunctuation = "!.,?".indexOf(currentSymbol) >= 0;
                    if (isVowel){
                        vowelCount++;
                    } else if(isConsonant){
                        consonantCount++;
                    } else if (isPunctuation){
                        punctuationCount++;
                    }
                }
                writer.println("Vowels: " + vowelCount);
                writer.println("Consonants: " + consonantCount);
                writer.println("Punctuation: " + punctuationCount);
                line = bfr.readLine();
            }
            writer.close();
            bfr.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
