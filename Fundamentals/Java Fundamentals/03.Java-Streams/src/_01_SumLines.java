/*
Write a program that reads a text file and prints on the console the sum of the ASCII symbols of each of its lines.
Use BufferedReader in combination with FileReader.
*/

import java.io.*;

public class _01_SumLines {
    public static void main(String[] args) {
        File readFile = new File("resources/_01_SumLinesResources/lines");
        try {
            BufferedReader bfr = new BufferedReader(new FileReader(readFile));
            String line = bfr.readLine();
            while(line != null){
                int sum = 0;
                for (int i = 0; i < line.length(); i++) {
                    sum += line.charAt(i);
                }
                System.out.println(sum);
                line = bfr.readLine();
            }
            bfr.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }


    }
}
