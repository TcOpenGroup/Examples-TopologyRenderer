using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_158_EK1100_E3D699B1 : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_160_EL1809;
		public PlainEL1809_32157CFD Term_160_EL1809
		{
			get
			{
				return _Term_160_EL1809;
			}

			set
			{
				if (_Term_160_EL1809 != value)
				{
					_Term_160_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_160_EL1809)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_158_EK1100_E3D699B1()
		{
			_Term_160_EL1809 = new PlainEL1809_32157CFD();
		}
	}
}