using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_186_EK1122_75C79D52 : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_187_EK1100_648C31BD _Term_187_EK1100;
		public PlainTerm_187_EK1100_648C31BD Term_187_EK1100
		{
			get
			{
				return _Term_187_EK1100;
			}

			set
			{
				if (_Term_187_EK1100 != value)
				{
					_Term_187_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_187_EK1100)));
				}
			}
		}

		PlainTerm_207_EK1100_2D36550A _Term_207_EK1100;
		public PlainTerm_207_EK1100_2D36550A Term_207_EK1100
		{
			get
			{
				return _Term_207_EK1100;
			}

			set
			{
				if (_Term_207_EK1100 != value)
				{
					_Term_207_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_207_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_186_EK1122_75C79D52()
		{
			_Term_187_EK1100 = new PlainTerm_187_EK1100_648C31BD();
			_Term_207_EK1100 = new PlainTerm_207_EK1100_2D36550A();
		}
	}
}