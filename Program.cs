class Program {
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        while(true)
        {
            Console.Write("Enter a number or type 'End to finish: ");
            string input = Console.ReadLine();
            
            if(input.ToLower() == "end")
            {
                break;
            }

            double number;
            if (!double.TryParse(input, out number))

            {
                Console.WriteLine("INvalid input. Please try again");
                continue;
            }

            numbers.Add(number);
        
        }

        while (true)
        {
            Console.Write("Enter mode (FindMax, FindMin, FindMean) or type 'End' to exist: ");
            string mode = Console.ReadLine();

                      if (mode.ToLower() == "end")
            {
                break;
            }

            switch (mode)
            {
                case "FindMax":
                    Console.WriteLine($"Max: {FindMax(numbers)}");
                    break;
                case "FindMin":
                    Console.WriteLine($"Min: {FindMin(numbers)}");
                    break;
                case "FindMean":
                    Console.WriteLine($"Mean: {FindMean(numbers)}");
                    break;
                default:
                    Console.WriteLine("Invalid mode.");
                    break;
            }
        }
    }

    static double FindMax(List<double> numbers)
    {
        double max = double.MinValue;
        foreach (double number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static double FindMin(List<double> numbers)
    {
        double min = double.MaxValue;
        foreach (double number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    static double FindMean(List<double> numbers)
    {
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Count;

        }
    }
