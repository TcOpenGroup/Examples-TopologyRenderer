using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_10_EK1122_3D069EC1 : Plc1.PlainEK1122_1FC0878B
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

		PlainTerm_23_EK1100_DFBF0BE4 _Term_23_EK1100;
		public PlainTerm_23_EK1100_DFBF0BE4 Term_23_EK1100
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

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_10_EK1122_3D069EC1()
		{
			_Term_11_EK1100 = new PlainTerm_11_EK1100_B6553301();
			_Term_18_EK1100 = new PlainTerm_18_EK1100_20659A8D();
			_Term_23_EK1100 = new PlainTerm_23_EK1100_DFBF0BE4();
		}
	}
}