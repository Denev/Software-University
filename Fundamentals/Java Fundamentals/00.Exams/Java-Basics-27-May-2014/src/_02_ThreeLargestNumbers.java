import java.util.*;
/**
 * Created by Denev on 18.10.2015 ã..
 */
public class _02_ThreeLargestNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int count = scanner.nextInt();
        String element = "";
        HashMap<String, Double> collection = new HashMap<>();
        for (int i = 0; i <= count; i++) {
            element = scanner.nextLine();
            if (!element.isEmpty()) {
                double numberElement = Double.valueOf(element);
                collection.put(element, numberElement);
            }
        }
        int anotherCount = 0;
        if (count == 1){
            for (Map.Entry<String, Double> e : collection.entrySet()) {
                double maxValue = Collections.max(collection.values());
                String key = e.getKey();
                Object value = e.getValue();
                if (value.equals(maxValue)){
                    System.out.println(key);
                    collection.remove(key);
                }
            }
        } else if (count == 2){
            for (int i = 0; i < 2; i++) {
                for (Map.Entry<String, Double> e : collection.entrySet()) {
                    double maxValue = Collections.max(collection.values());
                    String key = e.getKey();
                    Object value = e.getValue();
                    if (value.equals(maxValue)) {
                        System.out.println(key);
                        collection.remove(key);
                    }
                }
            }
        } else if (count > 2) {
               /* for (Map.Entry<String, Double> e : collection.entrySet()) {
                    double maxValue = Collections.max(collection.values());
                    String key = e.getKey();
                    Object value = e.getValue();
                    if (value.equals(maxValue)){
                        System.out.println(key);
                        anotherCount++;
                        collection.remove(key);
                    }
                } */
            while(anotherCount != 3) {
                Iterator<Map.Entry<String, Double>> iter = collection.entrySet().iterator();
                while (iter.hasNext()) {
                    Map.Entry<String, Double> entry = iter.next();
                    double maxValue = Collections.max(collection.values());
                    String key = entry.getKey();
                    Object value = entry.getValue();
                    if (anotherCount == 3){
                        break;
                    }
                    if (value.equals(maxValue)) {
                        System.out.println(key);
                        iter.remove();
                        collection.remove(key);
                        anotherCount++;
                    }
                }
            }
        }
    }
}

