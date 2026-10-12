using System.Security.Cryptography;

namespace operation_on_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            List<int> My_List = new List<int>();
            int number;
            char word ;
            do
            {
                Console.WriteLine("\n>> menu options : ");
                Console.WriteLine("P - Print numbers\r\nA - Add a number\r\nM - Display mean of the numbers\r\nF - Find a number in the list\r\nS - Display the smallest number\r\nL - Display the largest number\r\nQ - Quit\r\n");
                Console.WriteLine(">> Enter your choice : ");
                word = Convert.ToChar(Console.ReadLine().ToLower());

                switch (word)
                {
                    // ADD A NUMBER
                    case 'a':
                        Console.WriteLine("enter your number : ");                        
                        number = Convert.ToInt32(Console.ReadLine());
                        //don't allow duplicate entries 
                        if (My_List.Contains(number))
                        {
                            Console.WriteLine("duplicate number , not allowed");
                        }else
                        {
                            My_List.Add(number);
                            Console.WriteLine(number + " added");
                        }
                        break;

                    // PRINT THE LIST
                    case 'p':
                        if (My_List.Count != 0)
                        {
                            for (int i = 0; i < My_List.Count; i++)
                            {
                                Console.WriteLine($"[{My_List[i]}]");
                            }

                        }
                        else
                            Console.WriteLine("[] - the list is empty");
                        break;

                    // SMALLEST NUMBER IN THE LIST
                    case 's':
                        int smallest = My_List[0];
                        for (int i = 0; i < My_List.Count; i++)
                        {
                            if (My_List[i] < smallest)
                            {
                                smallest = My_List[i];

                            }
                        }
                        Console.WriteLine("the smallest number is :" + smallest);
                        break;

                    // LARGEST NUMBER IN THE LIST
                    case 'l':
                        int largest = My_List[0];

                        for (int i = 0; i < My_List.Count; i++)
                        {
                            if (My_List[i] > largest)
                            {
                                largest = My_List[i];
                            }
                        }
                        Console.WriteLine("the largest number is :" + largest);
                        break;

                    //FIND A NUMBER IN THE LIST
                    case 'f':
                        Console.WriteLine("enter the number you look for ..  ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (My_List.Contains(x))
                        {
                            Console.WriteLine($"{x} if found at index of {My_List.IndexOf(x)}");
                        }else
                            Console.WriteLine($"{x} not found at the list");
                        break;

                    //AVERAGE NUMBER
                    case 'm':
                        int sum = 0;
                        int average;
                        for (int i = 0; i < My_List.Count; i++)
                        {
                            sum += My_List[i];
                        }
                        average = sum / My_List.Count;
                        Console.WriteLine($"the mean : {average}");
                        break;

                    //CLEAR THE LIST
                    case 'c':
                        My_List.Clear();
                        Console.WriteLine("the list is cleared");
                        break;
                }

                //ENTER ANOTHER CHARACHTER
                if (word != 'a' && word != 'p' && word != 's' && word != 'l' && word != 'f' && word != 'm'
                    && word != 'c' && word != 'q') 
                {
                    Console.WriteLine("Unknown selection, please try again");
                }

            }
            while (word != 'q');

            //QUIT THE LOOP
            if(word == 'q')
            {
                Console.WriteLine("Good Bye");
            }

        }

    }
}
