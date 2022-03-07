namespace sorting;

public static class RandomArray {
    public static int[] Get() {
        var rand = new Random();
        var length = rand.Next(10, 50);
        var array = new int[length];

        for (int i = 0; i < length; i++) {
            array[i] = rand.Next(101);
        }

        return array;
    }
}