using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_207_EK1100_2D36550A : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_230_EK1122_16418046 _Term_230_EK1122;
		public PlainTerm_230_EK1122_16418046 Term_230_EK1122
		{
			get
			{
				return _Term_230_EK1122;
			}

			set
			{
				if (_Term_230_EK1122 != value)
				{
					_Term_230_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_230_EK1122)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_235_EL2008;
		public PlainEL2008_E2806B95 Term_235_EL2008
		{
			get
			{
				return _Term_235_EL2008;
			}

			set
			{
				if (_Term_235_EL2008 != value)
				{
					_Term_235_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_235_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_236_EL2008;
		public PlainEL2008_E2806B95 Term_236_EL2008
		{
			get
			{
				return _Term_236_EL2008;
			}

			set
			{
				if (_Term_236_EL2008 != value)
				{
					_Term_236_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_236_EL2008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_207_EK1100_2D36550A()
		{
			_Term_230_EK1122 = new PlainTerm_230_EK1122_16418046();
			_Term_235_EL2008 = new PlainEL2008_E2806B95();
			_Term_236_EL2008 = new PlainEL2008_E2806B95();
		}
	}
}