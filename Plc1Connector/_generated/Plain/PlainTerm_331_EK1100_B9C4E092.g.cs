using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_331_EK1100_B9C4E092 : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_332_EL1809;
		public PlainEL1809_32157CFD Term_332_EL1809
		{
			get
			{
				return _Term_332_EL1809;
			}

			set
			{
				if (_Term_332_EL1809 != value)
				{
					_Term_332_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_332_EL1809)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_331_EK1100_B9C4E092()
		{
			_Term_332_EL1809 = new PlainEL1809_32157CFD();
		}
	}
}