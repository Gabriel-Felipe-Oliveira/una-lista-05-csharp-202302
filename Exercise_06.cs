public class Exercise_06
{
    public static void Exercise(){

        const int students = 10;
        const int gradeLength = 4;
        const int minAverage = 7;

        float[,] inputs = new float[students, gradeLength];

        for(int studentId = 0; studentId < students; studentId++){
            for(int gradeId = 0; gradeId < gradeLength; gradeId++){

                float input;
                while(true){
                    Console.Write($"Insert the {gradeId + 1}º grade for {studentId + 1}º student: ");
                    if(float.TryParse(Console.ReadLine(), out input)){
                        inputs[studentId, gradeId] = input;
                        break;
                    }
                    else{
                        Console.WriteLine("Invalid value input");
                    }
                }
            }

        }

        for(int i = 0; i < students; i++){
            var average = Enumerable.Range(0, inputs.GetLength(1)).Select(g => inputs[i, g]).Average();
            if(average >= minAverage){
                Console.WriteLine($"Student {i+1} average: {average}");
            }
        }
    }
}