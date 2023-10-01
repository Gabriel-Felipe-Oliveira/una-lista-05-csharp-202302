public class Exercise_04
{
    public static void Exercise(){

        const int length = 10;
        char[] inputs = new char[length];

        for(int i = 0; i < inputs.Length; i++){
            char input;
            while(true){
                Console.Write("Insert a letter: ");
                if(char.TryParse(Console.ReadLine(), out input) && char.IsLetter(input)){
                    inputs[i] = input;
                    break;
                }
                else{
                    Console.WriteLine("Invalid value input");
                }
            }
        }

        var consonants = inputs.Where(c => !"aeiou".Contains(c.ToString().ToLower()));
        Console.WriteLine($"There are {consonants.Count()} consonants");

        string message = "[";
        for(int i = 0; i < consonants.Count(); i++){
            message += consonants.ElementAt(i);
            message += i + 1 == consonants.Count() ? "]" : ",";
        }

        Console.WriteLine($"Consonants: {message}");
    }
}