namespace OOAD_HW9.Problem1
{
    internal class BubbleSort : SortingStrategy
    {
        public override void Sort(Client client)
        {
            var collection = client.GetNumbers;

            int i, j, temp;
            bool swapped;
            for (i = 0; i < collection.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < collection.Count - i - 1; j++)
                {
                    if (collection[j] > collection[j + 1])
                    {
                        temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }
    }
}
