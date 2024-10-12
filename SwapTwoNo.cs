namespace AssignmentOct7
{
    public class SwapTwoNo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first No");
            int FirstNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second No");
            int SecondNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Swapping two numbers");
            FirstNo=FirstNo+SecondNo;
            SecondNo = FirstNo - SecondNo;
            FirstNo=FirstNo-SecondNo;
            Console.WriteLine("After swapping First No:" + FirstNo);
            Console.WriteLine("After swapping Second No:" + SecondNo);
        }
    }
}