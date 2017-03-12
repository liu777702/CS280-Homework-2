using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            Console.Write("請輸入一隻Pokemon:");
            try
            {
                pokemon.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("名稱輸入錯誤");
                Console.WriteLine("錯誤訊息" + e.ToString());
                return;
            }
            Console.Write("請輸入編號:");
            try
            {
                pokemon.Number = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("編號輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入身高:");
            try
            {
                pokemon.Height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("身高輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入體重:");
            try
            {
                pokemon.Weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("體重輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入類別:");
            try
            {
                pokemon.Category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("類別輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("請輸入能力:");
            try
            {
                pokemon.Abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("類別輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("請輸入性別:");
            try
            {
                pokemon.Gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("性別輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.WriteLine("名字:{0}，編號:{1}，身高:{2}公尺，體重:{3}磅，類別:{4}，能力:{5}，性別:{6}", pokemon.Name, pokemon.Number, pokemon.Height, pokemon.Weight
              , pokemon.Category, pokemon.Abilities, pokemon.Gender);
        }
    }
}