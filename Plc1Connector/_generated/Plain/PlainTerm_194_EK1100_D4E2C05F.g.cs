using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_194_EK1100_D4E2C05F : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_200_EL1809;
		public PlainEL1809_32157CFD Term_200_EL1809
		{
			get
			{
				return _Term_200_EL1809;
			}

			set
			{
				if (_Term_200_EL1809 != value)
				{
					_Term_200_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_200_EL1809)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_194_EK1100_D4E2C05F()
		{
			_Term_200_EL1809 = new PlainEL1809_32157CFD();
		}
	}
}