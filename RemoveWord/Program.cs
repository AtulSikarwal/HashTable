namespace HashTable
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("We find frequncy from hashmap !");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = "to be or not to be";
            string[]words=sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value=LinkedHashMap.Get(word);
                if(value == default)
                {
                    value = 1;
                }
                else value += 1;
                    LinkedHashMap.Add(word, value);
                
            }
            int frequency = LinkedHashMap.Get("not");
            Console.WriteLine(frequency);




            string Paragraph = "“Paranoids are not paranoid because they are " +
               "paranoid but because they keep putting themselves deliberately into" +
               " paranoid avoidable situations";
            string[] letters = Paragraph.ToLower().Split(" ");

            foreach (string word in letters)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency1 = LinkedHashMap.Get("paranoid");
            Console.WriteLine(frequency1);




            LinkedHashMap.Remove("avoidable");
            int frequency2 = LinkedHashMap.Get("avoidable");

            Console.WriteLine(frequency2);
        }


    }
}