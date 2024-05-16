namespace BmiV2
{
    /// <summary>
    /// Class này dùng chứa các Methol liên quan đến chỉ số sức khỏe của 1 cá nhân dinh dáng đến chiều cau và cần nặng.
    /// </summary>
    public class BmiCalculator
    {
        // các hàm liên quan Bmi 
        /// <summary>
        /// Hàm này tính ra chỉ số Bmi dựa trên ciều cao và cân nặng.
        /// </summary>
        /// <param name="weight">Cân nặng đo bằng Kg</param>
        /// <param name="height">Chiều cao đo bằng M</param>
        /// <returns></returns>
        /// 
        public static double GetBmi(double weight, double height) =>
        weight / (height * height);

            // Trong c# nếu hàm chỉ có 1 câu lệnh ta có cách viết  ăn bớt {} return
            // để hàm con tối thiểu 
            // kĩ thuật expresstion body - thân hàm nhìn như 1 biểu thức
            // cấm tuyệt đối nhầm lẫn cú pháp này với 1 loại hàm cũng xài => 
            // nhưng gọi là biểu thức lambda - lambda expresstion


            /* public static double GetBmi(double weight,double height)
             {
              return weight / (height*height);

             }*/
        //    static void PrintBmiString()
        //{
        //    Console.WriteLine("BMI srands for body mas index - chỉ số khối của cơ thể");
        //}
        static void PrintBmiString() => Console.WriteLine("BMI srands for body mas index - chỉ số khối của cơ thể");
        

    }
    }
