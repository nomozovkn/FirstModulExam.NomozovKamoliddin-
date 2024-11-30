namespace FirstModulExam
{
    internal class Program
    {
        /*1-misol
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 45, 41, 10, 3, 4 };
            Console.WriteLine(TwoRoomElementCounter(list));
           

        }
        public static  int TwoRoomElementCounter(List<int> list)
        {
            var counter = 0;
            foreach(var element in list)
            {
                if((element>9 && element<100) is true)
                {
                    counter++;
                }
            }
            return counter;
        }*/

        /*2-misol
        static void Main(string[] args)
        {
            Console.Write("Enter text:");
            var text= Console.ReadLine();
            Console.WriteLine(LastTwoSignDelete(text));
        }
        public static string LastTwoSignDelete(string text)
        {
            var substredText=text.Substring(0,text.Length-2);
            return substredText;
        }*/
        /*4-misol
        static void Main(string[] args)
        {
            Console.Write("Enter text:");
            var text= Console.ReadLine();
            Console.WriteLine(StartAndFinishQovun(text));
        }
        public static bool StartAndFinishQovun(string text)
        {
            var resultBool = false;
            if(text.StartsWith("qovun") && text.EndsWith("qovun"))
            {
                resultBool = true ;
            }
            return resultBool;
        }*/
        //3-misol
        static void Main(string[] args)
        {
            var lest = new List<string>() { "alom", "Hs", "Ags" };
            Console.WriteLine(AllElementFirstAlphaIsUpper(lest));
        }
        public static bool AllElementFirstAlphaIsUpper(List<string> list)
        {
            var resultBool = false;
            foreach (var element in list)
            {
                var result = element[0];
                if (result>='A' && result<='Z')
                {
                    resultBool = true;
                }
            }
            return resultBool;
        }
    }
}
