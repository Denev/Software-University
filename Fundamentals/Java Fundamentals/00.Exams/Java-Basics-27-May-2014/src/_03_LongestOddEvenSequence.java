import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Denev on 19.10.2015 ã..
 */
public class _03_LongestOddEvenSequence {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        List<String> inputCollection = new ArrayList<String>();
        Pattern pattern = Pattern.compile("\\(([^\\)]+)\\)");

        Matcher matcher = pattern.matcher(input);
        while (matcher.find()) {
            inputCollection.add(matcher.group(1));
        }
        List<Integer> collection = new ArrayList<Integer>();
        List<Integer> saveCollection = new ArrayList<Integer>();
        for (int i = 0; i < inputCollection.size(); i++) {
            collection.add(Integer.parseInt(inputCollection.get(i)));
            saveCollection.add(collection.get(i));
        }
        List<Integer> sequence = new ArrayList<Integer>();
        List<List<Integer>> doubleList = new ArrayList<List<Integer>>();
        //odd
        for (int j = 1; j < collection.size(); j++) {
            if (j % 2 != 0){
                if (collection.get(j - 1) % 2 != 0 && collection.get(j) % 2 == 0){
                    sequence.add(collection.get(j - 1));
                    sequence.add(collection.get(j));
                } else{
                    doubleList.add(sequence);
                    sequence.clear();
                }
            } else{
                if (collection.get(j - 1) % 2 == 0 && collection.get(j) % 2 != 0){
                    sequence.add(collection.get(j - 1));
                    sequence.add(collection.get(j));
                } else{
                    doubleList.add(sequence);
                    sequence.clear();
                }
            }
        }

    }
}
