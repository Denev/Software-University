/*
Write a program that reads a text file and changes the casing of all letters to upper.
The file should be overwritten. Use BufferedReader, FileReader, FileWriter, and PrintWriter.
*/

import java.io.*;

public class _02_AllCapitals {
    public static void main(String[] args) {

        File readFile = new File("resources/_02_AllCapitalsResources/lines");
        File writeFile = new File("resources/_02_AllCapitalsResources/result");
        try {
            BufferedReader bfr = new BufferedReader(new FileReader(readFile));
            String line = bfr.readLine();
            FileWriter fw = new FileWriter(writeFile, false);
            PrintWriter writer = new PrintWriter(fw, true);
            while(line != null){
                String upperCaseLine = line.toUpperCase();
                writer.println(upperCaseLine);
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
