using System.Collections.Generic;

namespace ChristmasGifts
{
	public class Calculator
	{
		private Dictionary<int, int> _2021Map = new Dictionary<int, int>()
		{
			{1, 3 },
			{2, 4 },
			{3, 1 },
			{4, 2 }
		};

		public Dictionary<int, int> Calculate(int year)
		{
			Dictionary<int, int> newMap = new Dictionary<int, int>();
			int diff = year - 2021;

			for (int i = 1; i < 5; i++)
			{
				_ = _2021Map.TryGetValue(i, out int recipient);

				for (int j = 0; j < diff; j++)
				{
					recipient++;
					if (recipient == i)
					{
						recipient++;
					}
					if (recipient > 4)
					{
						recipient = 1;
					}
					if (recipient == i)
					{
						recipient++;
					}
				}

				newMap.Add(i, recipient);
			}

			return newMap;
		}
	}
}