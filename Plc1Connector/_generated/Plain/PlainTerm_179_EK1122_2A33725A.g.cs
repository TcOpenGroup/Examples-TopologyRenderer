using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_179_EK1122_2A33725A : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_180_EK1100_796B7783 _Term_180_EK1100;
		public PlainTerm_180_EK1100_796B7783 Term_180_EK1100
		{
			get
			{
				return _Term_180_EK1100;
			}

			set
			{
				if (_Term_180_EK1100 != value)
				{
					_Term_180_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_180_EK1100)));
				}
			}
		}

		PlainTerm_182_EK1100_E6B2C35E _Term_182_EK1100;
		public PlainTerm_182_EK1100_E6B2C35E Term_182_EK1100
		{
			get
			{
				return _Term_182_EK1100;
			}

			set
			{
				if (_Term_182_EK1100 != value)
				{
					_Term_182_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_182_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_179_EK1122_2A33725A()
		{
			_Term_180_EK1100 = new PlainTerm_180_EK1100_796B7783();
			_Term_182_EK1100 = new PlainTerm_182_EK1100_E6B2C35E();
		}
	}
}