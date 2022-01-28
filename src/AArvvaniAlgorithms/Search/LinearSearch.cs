namespace AArvvaniAlgorithms.Search
{
    public class LinearSearch
    {
        public bool Search(int[] numbers, int search) {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                    return true;
            }
            return false;
        }
    }
}
