using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_230_EK1122_16418046 : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_231_EK1100_6FCE8CEB _Term_231_EK1100;
		public PlainTerm_231_EK1100_6FCE8CEB Term_231_EK1100
		{
			get
			{
				return _Term_231_EK1100;
			}

			set
			{
				if (_Term_231_EK1100 != value)
				{
					_Term_231_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_231_EK1100)));
				}
			}
		}

		PlainTerm_233_EK1100_CB654C3B _Term_233_EK1100;
		public PlainTerm_233_EK1100_CB654C3B Term_233_EK1100
		{
			get
			{
				return _Term_233_EK1100;
			}

			set
			{
				if (_Term_233_EK1100 != value)
				{
					_Term_233_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_233_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_230_EK1122_16418046()
		{
			_Term_231_EK1100 = new PlainTerm_231_EK1100_6FCE8CEB();
			_Term_233_EK1100 = new PlainTerm_233_EK1100_CB654C3B();
		}
	}
}