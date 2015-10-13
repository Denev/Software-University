/*
Print the characters from ‘a’ to ‘z’ on the console on a single line, separated by a space.
Use a for-loop. Note: you can directly declare and increment char in the for-loop. for (char c = ‘a’; …)
*/

public class _04_PrintCharacters {
    public static void main(String[] args) {

        for (char symbol = 'a'; symbol <= 'z'; symbol++) {
            if (symbol != 'z') {
                System.out.print(symbol + " ");
            }
            else {
                System.out.print(symbol);
            }
        }
    }
}

