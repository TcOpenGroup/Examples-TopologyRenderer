using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_42_EK1100_1039F2C4 : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1008_78E8D3DD _Term_43_EL1008;
		public PlainEL1008_78E8D3DD Term_43_EL1008
		{
			get
			{
				return _Term_43_EL1008;
			}

			set
			{
				if (_Term_43_EL1008 != value)
				{
					_Term_43_EL1008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_43_EL1008)));
				}
			}
		}

		PlainEL1008_78E8D3DD _Term_44_EL1008;
		public PlainEL1008_78E8D3DD Term_44_EL1008
		{
			get
			{
				return _Term_44_EL1008;
			}

			set
			{
				if (_Term_44_EL1008 != value)
				{
					_Term_44_EL1008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_44_EL1008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_42_EK1100_1039F2C4()
		{
			_Term_43_EL1008 = new PlainEL1008_78E8D3DD();
			_Term_44_EL1008 = new PlainEL1008_78E8D3DD();
		}
	}
}