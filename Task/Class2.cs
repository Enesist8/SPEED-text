namespace SpeedText
{
    internal class Main
    {
        public static string name;
        public static int chr_p_min;
        public static int chr_p_sec;
        Write_Text txt = new Write_Text();
        public static List<Data> users = new List<Data>();
        public string text = "Предложение – это слово или несколько, связанных между собой по смыслу и выражающих законченную мысль.";
        /*public bool we_are_in_menu = true;*/
        public void programm()
        {
            Menu();
        }
        private void Menu()
        {
            Console.WriteLine("Input your name for table of records:");
            name = Console.ReadLine();
            Test();
        }
        private void Test()
        {
            Console.Clear();
            Console.WriteLine(text);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Press Enter when you are ready");
            ConsoleKeyInfo klue = Console.ReadKey();
            if (klue.Key == ConsoleKey.Enter)
            {
                char[] content = text.ToArray();
                txt.User_Writes(content);
            }
        }
    }
}