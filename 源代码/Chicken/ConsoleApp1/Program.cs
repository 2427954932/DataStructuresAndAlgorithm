using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int cock = 0;//公鸡的数量公鸡5元一只

			int hen = 0;//母鸡的数量母鸡3元一只

			int chick = 0;//小鸡的数量小鸡1元三只

			int index = 1;//方案

			for (cock = 0; cock <= 20; cock++)//100块最多买20只公鸡

			{

				for (hen = 0; hen <= 33; hen++)//100块最多买33只母鸡

				{

					chick = 100 - cock - hen;

					if (3 * hen + 5 * cock + chick / 3.0 == 100)

					{

						Console.WriteLine("第{0}中方案：", index++);

						Console.WriteLine("公鸡的数量为:" + cock);

						Console.WriteLine("母鸡的数量为:" + hen);

						Console.WriteLine("小鸡的数量为:" + chick);

					}

				}

			}

			Console.ReadKey();//小鸡鸡
		}
	}
}
