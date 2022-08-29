namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Map!!!");

            LinkedHashMap<string, int> hashMap = new LinkedHashMap<string, int>(5);
            string sentence = "to be or not to be";
            string[] words = sentence.ToLower().Split(" ");
            foreach (var word in words)
            {
                int value = hashMap.Get(word);
                if (value == default)
                    value = 1;
                else
                    value += 1;
                hashMap.Add(word, value);
            }

            int wordFrequency = hashMap.Get("to");
            Console.WriteLine("frequency of word \"to\" in sentense \"to be or not to be\" is ");
            Console.WriteLine(wordFrequency);
        }
    }
}