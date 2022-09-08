using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_24_EK1122_39E7B5CB : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_25_EK1100_08217EB4 _Term_25_EK1100;
		public PlainTerm_25_EK1100_08217EB4 Term_25_EK1100
		{
			get
			{
				return _Term_25_EK1100;
			}

			set
			{
				if (_Term_25_EK1100 != value)
				{
					_Term_25_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_25_EK1100)));
				}
			}
		}

		PlainTerm_28_EK1100_415F4A7E _Term_28_EK1100;
		public PlainTerm_28_EK1100_415F4A7E Term_28_EK1100
		{
			get
			{
				return _Term_28_EK1100;
			}

			set
			{
				if (_Term_28_EK1100 != value)
				{
					_Term_28_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_28_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_24_EK1122_39E7B5CB()
		{
			_Term_25_EK1100 = new PlainTerm_25_EK1100_08217EB4();
			_Term_28_EK1100 = new PlainTerm_28_EK1100_415F4A7E();
		}
	}
}