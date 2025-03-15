namespace Sorting
{
    public class QuickSort
    {
        int[] array = { 8, 4, 8, 3, 3 };

        public int[] SortArray(ref int[] array)
        {
            int pivot = array.Length - 1;
            
            Sort (array,0,array.Length-1);
                
            return array;
        }

        private void Sort(int[] array,int start,int stop)
        {
            int temp,pivot=stop,i=start-1,j=0;

            if (stop <= start)
                return;

            for (j = start; j <= stop; j++)
            {
                if (array[j] < array[pivot])
                {
                    temp = array[++i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            i++;
            temp = array[i];
            array[i] = array[pivot];
            array[pivot] = temp;
            pivot = i;
            

        
             Sort (array,start,pivot-1);

             Sort (array,pivot+1,stop);
        }
        //private void SortLeft
    }
}
