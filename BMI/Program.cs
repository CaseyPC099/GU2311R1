namespace BMI{
    class Program
    {
        private static void Main(string[] args){
            Console.WriteLine("Nhap Can Nang:");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Chieu Cao:");
            float height = float.Parse(Console.ReadLine());
            double BMI1 = weight/(height*height);
            int BMI = (int) BMI1;
            if (BMI < 18){
                Console.WriteLine("Gay");
            }
            if (BMI < 25){
                Console.WriteLine("Binh thuong");
            }
            if (BMI < 30){
                Console.WriteLine("Beo Phi");
            }
            if (BMI > 30){
                Console.WriteLine("Nhap lai:");
        }
    }
    }
}