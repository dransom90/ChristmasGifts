using System.Collections.Generic;
using System.ComponentModel;

namespace ChristmasGifts
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private int _selectedYear = 2021;
		private string _dj;
		private string _ac;
		private string _tr;
		private string _jt;
		private readonly Calculator _calculator = new Calculator();

		public int SelectedYear
		{
			get => _selectedYear;
			set
			{
				_selectedYear = value;
				Update();
			}
		}

		public string DJ
		{
			get => _dj;
			set
			{
				_dj = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DJ)));
			}
		}

		public string AC
		{
			get => _ac;
			set
			{
				_ac = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AC)));
			}
		}

		public string TR
		{
			get => _tr;
			set
			{
				_tr = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TR)));
			}
		}

		public string JT
		{
			get => _jt;
			set
			{
				_jt = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(JT)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Update()
		{
			Dictionary<int, int> map = _calculator.Calculate(SelectedYear);

			_ = map.TryGetValue(1, out int value);
			Name name = (Name)value;
			DJ = name.ToString();

			_ = map.TryGetValue(2, out value);
			name = (Name)value;
			AC = name.ToString();

			_ = map.TryGetValue(3, out value);
			name = (Name)value;
			TR = name.ToString();

			_ = map.TryGetValue(4, out value);
			name = (Name)value;
			JT = name.ToString();
		}
	}
}