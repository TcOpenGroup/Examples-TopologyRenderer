using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_330_EK1122_0EDE60FE : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_331_EK1100_B9C4E092 _Term_331_EK1100;
		public PlainTerm_331_EK1100_B9C4E092 Term_331_EK1100
		{
			get
			{
				return _Term_331_EK1100;
			}

			set
			{
				if (_Term_331_EK1100 != value)
				{
					_Term_331_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_331_EK1100)));
				}
			}
		}

		PlainTerm_333_EK1100_1D6F2042 _Term_333_EK1100;
		public PlainTerm_333_EK1100_1D6F2042 Term_333_EK1100
		{
			get
			{
				return _Term_333_EK1100;
			}

			set
			{
				if (_Term_333_EK1100 != value)
				{
					_Term_333_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_333_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_330_EK1122_0EDE60FE()
		{
			_Term_331_EK1100 = new PlainTerm_331_EK1100_B9C4E092();
			_Term_333_EK1100 = new PlainTerm_333_EK1100_1D6F2042();
		}
	}
}