using System;

public static class ArrayUtilities
{
    // This method shuffles the elements of the given array in place using the Fisher-Yates shuffle algorithm.
    private static void ShuffleArray<T>(IList<T> array)
    {
        // Check for null or empty array to avoid unnecessary processing.
        if (array == null || array.Count <= 1)
        {
            return;
        }

        // Create a new instance of Random for generating random indices.
        Random rng = new Random();

        // Loop through the array starting from the last element.
        for (int i = array.Count - 1; i > 0; i--)
        {
            // Generate a random index between 0 and i (inclusive).
            int swapIndex = rng.Next(i + 1);

            // Swap the element at the current index with the element at the random index.
            T temp = array[i];
            array[i] = array[swapIndex];
            array[swapIndex] = temp;
        }
    }
}
