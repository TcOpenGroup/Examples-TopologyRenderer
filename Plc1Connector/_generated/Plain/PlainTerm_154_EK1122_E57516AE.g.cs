using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_154_EK1122_E57516AE : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_157_EK1100_7C4BDD77 _Term_157_EK1100;
		public PlainTerm_157_EK1100_7C4BDD77 Term_157_EK1100
		{
			get
			{
				return _Term_157_EK1100;
			}

			set
			{
				if (_Term_157_EK1100 != value)
				{
					_Term_157_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_157_EK1100)));
				}
			}
		}

		PlainTerm_158_EK1100_E3D699B1 _Term_158_EK1100;
		public PlainTerm_158_EK1100_E3D699B1 Term_158_EK1100
		{
			get
			{
				return _Term_158_EK1100;
			}

			set
			{
				if (_Term_158_EK1100 != value)
				{
					_Term_158_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_158_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_154_EK1122_E57516AE()
		{
			_Term_157_EK1100 = new PlainTerm_157_EK1100_7C4BDD77();
			_Term_158_EK1100 = new PlainTerm_158_EK1100_E3D699B1();
		}
	}
}