namespace _3CalcSum
{
    /// <summary>
    /// add numbers from 1 to N
    ///
    /// INPUTS:  a number "N"
    /// CALCULATION:  add 1 + 2+...+N
    /// OUTPUT: the sum of all the numbers
    /// </summary>
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                CalcSum();
            }

            //while (counter < input)
            //{
            //    sum += counter;

            //}

            //while (sum < input)
            //{
            //    sum += counter;
            //}

            //while (counter < input)
            //{
            //    var numb = 1;
            //    counter +=( numb+1 );

            //    sum = numb + numb + 1;
            //}
        }

        private static void CalcSum()
        {
            var input = ReadHelper("Input a number, and we will add all numbers from 1 till that together and output the sum!");

            //var sum = 0;
            //var counter = input;

            //while (counter >= 1)
            //{
            //    sum += counter;
            //    counter -= 1;
            //}


            var sum = 0;
            var counter = 1;

            while (counter <= input)  //input = 3
            {
                //Console.WriteLine($"+{counter}");
                sum += counter;
                counter += 1;
            }





            Console.WriteLine($"Your answer is {sum}");
        }

        private static int ReadHelper(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var isValid = int.TryParse(input, out var intVal);

            if (isValid)
            {
                Console.WriteLine($"{intVal}? okay!");
                return intVal;
            }
            else
            {
                Console.WriteLine("Nova says, 'That is not correct, please try again.'  Enter a number!");
                return ReadHelper(message);
            }

        }
    }
}