import java.util.Scanner;

/**
 * Created by Denev on 18.10.2015 ã..
 */
public class _01_CountBeers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        int sum = 0;
        while(!input.equals("End")){
            String[] command = input.split(" ");
            int count = Integer.parseInt(command[0]);
            String stackOrBeer = command[1];
            if (stackOrBeer.equals("stacks")){
                sum += 20 * count;
            } else{
                sum += count;
            }
            input = scanner.nextLine();
        }
        int stacks = sum / 20;
        int beers = sum % 20;
        System.out.printf("%d stacks + %d beers", stacks, beers);
    }
}
