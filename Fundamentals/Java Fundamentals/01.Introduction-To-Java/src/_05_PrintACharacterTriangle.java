import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/*
Create a triangle of characters, based on input.
Learn about java.util.Scanner and Integer.parseInt ().
Test your program with integers up to 26. Think why.
*/

public class _05_PrintACharacterTriangle {
    public static void main(String[] args) {
        //We will until 26, because the English alphabet has a total of 26 letters.
        Scanner scanner = new Scanner(System.in);
        int length = scanner.nextInt();
        char symbol = 'a';
        List<Character> myList = new ArrayList<Character>();
        for (int i = 0; i < length; i++) {
            myList.add((char)(symbol + i));
            for (int j = 0; j < myList.size(); j++){
                System.out.print(myList.get(j) + " ");
            }
            System.out.println();
        }
        for (int i = length - 1; i >= 1; i--) {
            myList.remove(i);
            for (int j = 0; j < myList.size(); j++){
                System.out.print(myList.get(j) + " ");
            }
            System.out.println();
        }
    }
}
