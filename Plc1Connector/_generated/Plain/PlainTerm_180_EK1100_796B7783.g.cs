using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_180_EK1100_796B7783 : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_181_EL1809;
		public PlainEL1809_32157CFD Term_181_EL1809
		{
			get
			{
				return _Term_181_EL1809;
			}

			set
			{
				if (_Term_181_EL1809 != value)
				{
					_Term_181_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_181_EL1809)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_180_EK1100_796B7783()
		{
			_Term_181_EL1809 = new PlainEL1809_32157CFD();
		}
	}
}