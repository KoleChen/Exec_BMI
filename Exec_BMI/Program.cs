using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高(公尺)：");
            string height = Console.ReadLine();
            float numheight = float.Parse(height);

            Console.Write("請輸入體重(公斤)：");
            string weight = Console.ReadLine();
            int numweight = int.Parse(weight);

            BMI Number = new BMI();
            Number.CountHeight = numheight;
            Number.CountWeight = numweight;
            double BMI = Number.CountBMI();
            Console.WriteLine("您的BMI為"+BMI.ToString("0.00"));
        }
    }
    class BMI
    {
        private float height;
        public float CountHeight
        {
            get { return height; }
            set { height = value; }
        }

		private int weight;
		public int CountWeight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double CountBMI()
        {
            return weight / (height*height);
        }


    }
}
