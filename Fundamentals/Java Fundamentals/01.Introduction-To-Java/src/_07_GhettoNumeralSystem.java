import java.util.Scanner;

/*
Write a program that converts the decimal number system to the ghetto numeral system. In the ghetto, numbers are represented as following:
?	0 – Gee
?	1 – Bro
?	2 – Zuz
?	3 – Ma
?	4 – Duh
?	5  - Yo
?	6 – Dis
?	7 – Hood
?	8 – Jam
?	9 – Mack
*/

public class _07_GhettoNumeralSystem {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String number = scanner.nextLine();
        String[] result = number.split("");

        ChangeValues(number, result);
        OutputNumber(result);
    }

    private static void OutputNumber(String[] result) {
        for (int i = 0; i < result.length; i++)
        {
            System.out.print(result[i]);
        }
    }

    private static void ChangeValues(String number, String[] result) {
        for (int i = 0; i < number.length(); i++){
            switch (result[i]){
                case "0":
                    result[i] = "Gee";
                    break;
                case "1":
                    result[i] = "Bro";
                    break;
                case "2":
                    result[i] = "Zuz";
                    break;
                case "3":
                    result[i] = "Ma";
                    break;
                case "4":
                    result[i] = "Duh";
                    break;
                case "5":
                    result[i] = "Yo";
                    break;
                case "6":
                    result[i] = "Dis";
                    break;
                case "7":
                    result[i] = "Hood";
                    break;
                case "8":
                    result[i] = "Jam";
                    break;
                case "9":
                    result[i] = "Mack";
                    break;
            }

        }
    }

}
