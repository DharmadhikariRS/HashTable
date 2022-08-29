namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Map!!!");

            LinkedHashMap<string, int> hashMap = new LinkedHashMap<string, int>(5);
          //UC1
            //string sentence = "to be or not to be";
        
            //UC2
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting " +
                            "themselves deliberately into paranoid avoidable situations"
               ;
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

            // int wordFrequency = hashMap.Get("to");
            // Console.WriteLine("frequency of word \"to\" in sentense \"to be or not to be\" is "+wordFrequency);
           
            int wordFrequency = hashMap.Get("paranoid");
            Console.WriteLine("frequency of word \"paranoid\" is " + wordFrequency);

        }
    }
}