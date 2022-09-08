using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_182_EK1100_E6B2C35E : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_183_EL1809;
		public PlainEL1809_32157CFD Term_183_EL1809
		{
			get
			{
				return _Term_183_EL1809;
			}

			set
			{
				if (_Term_183_EL1809 != value)
				{
					_Term_183_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_183_EL1809)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_182_EK1100_E6B2C35E()
		{
			_Term_183_EL1809 = new PlainEL1809_32157CFD();
		}
	}
}