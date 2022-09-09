using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_10_EK1122_152EB6C2 : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_11_EK1100_B6553301 _Term_11_EK1100;
		public PlainTerm_11_EK1100_B6553301 Term_11_EK1100
		{
			get
			{
				return _Term_11_EK1100;
			}

			set
			{
				if (_Term_11_EK1100 != value)
				{
					_Term_11_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_11_EK1100)));
				}
			}
		}

		PlainTerm_18_EK1100_20659A8D _Term_18_EK1100;
		public PlainTerm_18_EK1100_20659A8D Term_18_EK1100
		{
			get
			{
				return _Term_18_EK1100;
			}

			set
			{
				if (_Term_18_EK1100 != value)
				{
					_Term_18_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_18_EK1100)));
				}
			}
		}

		PlainTerm_23_EK1100_C1096874 _Term_23_EK1100;
		public PlainTerm_23_EK1100_C1096874 Term_23_EK1100
		{
			get
			{
				return _Term_23_EK1100;
			}

			set
			{
				if (_Term_23_EK1100 != value)
				{
					_Term_23_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_23_EK1100)));
				}
			}
		}

		PlainTerm_42_EK1100_1039F2C4 _Term_42_EK1100;
		public PlainTerm_42_EK1100_1039F2C4 Term_42_EK1100
		{
			get
			{
				return _Term_42_EK1100;
			}

			set
			{
				if (_Term_42_EK1100 != value)
				{
					_Term_42_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_42_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_10_EK1122_152EB6C2()
		{
			_Term_11_EK1100 = new PlainTerm_11_EK1100_B6553301();
			_Term_18_EK1100 = new PlainTerm_18_EK1100_20659A8D();
			_Term_23_EK1100 = new PlainTerm_23_EK1100_C1096874();
			_Term_42_EK1100 = new PlainTerm_42_EK1100_1039F2C4();
		}
	}
}