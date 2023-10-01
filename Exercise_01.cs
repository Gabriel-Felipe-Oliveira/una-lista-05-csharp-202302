public class Exercise_01
{
    public static void Exercise(){

        const int length = 5;
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

        for(int i = 0; i < inputs.Length; i++){
            Console.WriteLine($"Value {i + 1}: {inputs[i]}");
        }
    }
}