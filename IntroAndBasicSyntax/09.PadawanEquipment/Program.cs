using System;

namespace _09.PadawanEquipment
{
	class Program
	{
		static void Main(string[] args)
		{
			float money = float.Parse(Console.ReadLine());
			int students = int.Parse(Console.ReadLine());
			float priceSabre = float.Parse(Console.ReadLine());
			float priceRobe = float.Parse(Console.ReadLine());
			float priceBelt = float.Parse(Console.ReadLine());
			float neededMoney = 0;
		
			int studentsForSabres = (int)Math.Ceiling(students + 0.1 * students);
			float priceSabres = studentsForSabres * priceSabre;	
			float priceBelts = students * priceRobe;

			int freeBelts = students / 6;
			students -= freeBelts;
			float priceRobes = students  * priceRobe;

			neededMoney = priceBelts + priceRobes + priceSabres;

			if(money > neededMoney)
			{
				float moneyLeft = money - neededMoney;
				Console.WriteLine($"The money is enough - it would cost {moneyLeft:F2}lv.");
			}
			else
			{
				float moneyMore = neededMoney - money;
				Console.WriteLine($"Ivan Cho will need {moneyMore:F2}lv more.");
			}
		}
	}
}
