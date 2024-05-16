namespace IntergersV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumA, sumO, sumE, countE, primeP;
            sumA = ComputeNumbers(out sumO, out sumE, out countE, out primeP);
            Console.WriteLine("tổng all : " + sumA);
            Console.WriteLine("tổng lẻ  : " + sumO);
            Console.WriteLine("tổng chẵn : " + sumE);
            Console.WriteLine("có ? số chẵn : " + countE);
            Console.WriteLine("có ? số prime : " + primeP);
        }

        /* static void Main(string[] args) 
         {
             // xài hàm 
             //c1 : khai báo 1 biến , đưa vào hàm , Có cần gán value cho biến hay ko ? 
             int x = 10;
             PowerV3(out x);
             Console.WriteLine("x:" + x);
             // cách 2 : không cần  gán giá trị đầu vào do hàm out hứa sẽ có value được đổ vô, thích gán cũng được nhưng sẽ bị hàm đè mất value 
             int y;
             PowerV3(out y );
             Console.WriteLine("y: " + y);
             //cách 3 chat gpt hay dùng 
             PowerV3(out int z);
             Console.WriteLine("z: " + z);
             // khai báo ngay trong lúc gọi hàm 
             */

        static void PowerV3(out int n)
        {// trong ham   em hứa , em sẽ return 1 giá trị nào đó có
         // thể qua biến n , out nghĩa là hứa chắc chắn sẽ có 
            n = 100;
        }
        //static void Main(string[] args)
        //{
        //    int x = 10;

        //    PowerBy2(x);
        //    Console.WriteLine(" in main() x now is " + x);
        //}

        //// thử nghiệm với OUT 
        //// keyword này chỉ dùng ở tham số hàm 
        //// viet hàm nhận vào 1 số và tăng số đò lên bình phương , đưa vào x = 10 , trả về 100 , cấm dùng Return 

        static void PowerBy2(int n)
        {
            n = n * n;
            // in thử
            Console.WriteLine(" in nethold n now is " + n);
        }
        // chalenge 7 viết hàm tính tổng trả về , xử lý các con số riwf 1 đến 100
        // //_ trả về một lượt tổng các só chẵn , tổng số lẻ , số sô chẵn
        // //- có bao nhiêu sô nguyên tố 
        // có bao nhiêu số chia hết cho 5
        // chỉ viết 1 hàm 

        // hàm này trả về sum 1 - 100 , trả về tổng số lẻ , tổng số chẵn 
        static int ComputeNumbers(out int sumOdds, out int eventCount, out int evenSum, out int countPrime)
        {
            int sumAll = 0;
            sumOdds = 0;
            evenSum = 0;
            eventCount = 0;
            countPrime = 0;


            for (int i = 1; i <= 10; i++)
            {
                sumAll = sumAll + i;
                if (i % 2 == 0)
                {
                    eventCount++; // đếm 1 con chãn
                    evenSum += i; // sum số chẵn
                }
                else
                    sumOdds += i;
                if (IsPrime(i))
                {
                    countPrime++;
                }
            }
            return sumAll;

        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }

            return true;


        }
    }
}
// conclution :
// out là kĩ thuật truyền tham chiếu ( địa chỉ vùng ram )  cho biến khác giữu - Pass by refferent | chỉ được fingf ở tham số hàm
// giúp hàm trả về cùng lúc nhiều giá trị qua nahcsh | đường | tham số 
// out : nghiêm túc , trong code cảu hàm out , bắt buộc phải có lệnh mào đó để gán 1 giá tựi cụ thể cho biến out này 
// out : ha trong hám sẽ trả về bên ngoài 1 giá trị 
// hậu trường ::
// 