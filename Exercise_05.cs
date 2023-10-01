public class Exercise_05
{
    public static void Exercise(){

        const int length = 20;
        int[] inputs = new int[length];

        for(int i = 0; i < inputs.Length; i++){
            int input;
            while(true){
                Console.Write("Insert a integer: ");
                if(int.TryParse(Console.ReadLine(), out input)){
                    inputs[i] = input;
                    break;
                }
                else{
                    Console.WriteLine("Invalid value input");
                }
            }
        }

        var evens = inputs.Where(e => e%2 == 0).ToArray();
        var odds = inputs.Where(e => e%2 != 0).ToArray();
        
        PrintArray(inputs, "Numbers");
        PrintArray(evens, "Even numbers");
        PrintArray(odds, "Odd numbers");
    }

    public static void PrintArray(int[] array, string arrayName){
        Console.WriteLine($"\n{arrayName}:");
        string message = "[";
        for(int i = 0; i < array.Length; i++){
            message += array[i];
            message += i + 1 == array.Length ? "]" : ",";
        }
        Console.WriteLine(message);
    }
}