using System.Text;
class Exercise10
{
    static void Main()
    {
        int mark = 0, k = 0, sum = 0;
        string nums;
        int[] numbers;
        bool errorCatch = false;

        Console.Write("Please enter a sequence of numbers and seperate them with spaces: ");
        nums = Console.ReadLine();
        numbers = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {

            StringBuilder ld = new StringBuilder();

            if (string.Equals(nums[i], ' '))
            {
                StringBuilder sb = new StringBuilder();
                
                for (int j = mark; j < i; j++)
                {
                    sb.Append(nums[j]);
                }
                errorCatch = int.TryParse(sb.ToString(), out numbers[k]);
                
                if (errorCatch)
                {
                    k++;
                    mark = i;
                }


            }

            if (i == nums.Length - 2)
            {
                for (int j = mark; j < nums.Length; j++)
                {
                    ld.Append(nums[j]);
                }

                errorCatch = int.TryParse(ld.ToString(), out numbers[k]);

                if (errorCatch)
                {
                    k++;
                    mark = i;
                }

            }
        }

        for (int i = 0; i < k; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("\nThe sum is {0}", sum);
    }
}