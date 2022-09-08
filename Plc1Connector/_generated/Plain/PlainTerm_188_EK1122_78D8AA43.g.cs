using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_188_EK1122_78D8AA43 : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_189_EK1100_06A16014 _Term_189_EK1100;
		public PlainTerm_189_EK1100_06A16014 Term_189_EK1100
		{
			get
			{
				return _Term_189_EK1100;
			}

			set
			{
				if (_Term_189_EK1100 != value)
				{
					_Term_189_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_189_EK1100)));
				}
			}
		}

		PlainTerm_194_EK1100_D4E2C05F _Term_194_EK1100;
		public PlainTerm_194_EK1100_D4E2C05F Term_194_EK1100
		{
			get
			{
				return _Term_194_EK1100;
			}

			set
			{
				if (_Term_194_EK1100 != value)
				{
					_Term_194_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_194_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_188_EK1122_78D8AA43()
		{
			_Term_189_EK1100 = new PlainTerm_189_EK1100_06A16014();
			_Term_194_EK1100 = new PlainTerm_194_EK1100_D4E2C05F();
		}
	}
}