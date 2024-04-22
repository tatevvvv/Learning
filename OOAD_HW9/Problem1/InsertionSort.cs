namespace OOAD_HW9.Problem1
{
    internal class InsertionSort : SortingStrategy
    {
        public override void Sort(Client client)
        {
            var collection = client.GetNumbers;

            for (int i = 1; i < collection.Count; ++i)
            {
                int key = collection[i];
                int j = i - 1;

                while (j >= 0 && collection[j] > key)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }
                collection[j + 1] = key;
            }
        }
    }
}
