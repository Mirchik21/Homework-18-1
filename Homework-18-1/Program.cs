namespace Homework_18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameList myNameList = new NameList();
        }
    }

    class NameList
    {
        public string Name1;
        public string Name2;
        public string And;
        public NameList()
        {
            Console.WriteLine("Dear user works the first method");
            InputNameList();
            Console.WriteLine("Dear user works the second method");
            InputNameList2();
            Console.WriteLine("Dear user works the third method");
            Console.WriteLine("Here you can keep an unlimited number of names");
            InputNamelist3(Console.ReadLine());
        }

        public void InputNameList()
        {
            Console.WriteLine("Enter is first name: ");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Enter is second name: ");
            string Name2 = Console.ReadLine();
            string And = ", ";
            Console.WriteLine(Name1 + And + Name2);
        }
        public void InputNameList2()
        {
            Console.WriteLine("Enter is first name: ");
            string Name1 = Console.ReadLine();
            Console.WriteLine("Enter any character (, . + - = / | ; ' : { } [ ] ) to separate the names: ");
            string And = Console.ReadLine();
            Console.WriteLine("Enter is second name: ");
            string Name2 = Console.ReadLine();
            Console.WriteLine(Name1 + And + " " + Name2);
        }
        public static void InputNamelist3(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            { 
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            InputNamelist3(Console.ReadLine());
        }
    }

}