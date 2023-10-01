public class Exercise_02
{
    public static void Exercise(){

        const int length = 10;
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

        for(int i = inputs.Length - 1; i >= 0; i--){
            Console.WriteLine($"Value {i + 1}: {inputs[i]}");
        }
    }
}