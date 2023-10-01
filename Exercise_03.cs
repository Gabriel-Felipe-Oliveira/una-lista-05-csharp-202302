public class Exercise_03
{
    public static void Exercise(){

        const int length = 4;
        int[] inputs = new int[length];

        for(int i = 0; i < inputs.Length; i++){
            int input;
            while(true){
                Console.Write("Insert a grade: ");
                if(int.TryParse(Console.ReadLine(), out input)){
                    inputs[i] = input;
                    break;
                }
                else{
                    Console.WriteLine("Invalid value input");
                }
            }
        }

        float average = (float)inputs.Sum()/inputs.Count();

        string message = "";
        for(int i = 0; i < inputs.Length; i++){
            message += $"[{inputs[i]}] ";
        }
        Console.WriteLine($"Grades: {message}\nAverage: {average}");
    }
}