using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_289_EK1100_9C677E50 : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_237_EK1122_86A8F7BD _Term_237_EK1122;
		public PlainTerm_237_EK1122_86A8F7BD Term_237_EK1122
		{
			get
			{
				return _Term_237_EK1122;
			}

			set
			{
				if (_Term_237_EK1122 != value)
				{
					_Term_237_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_237_EK1122)));
				}
			}
		}

		PlainEL1809_32157CFD _Term_293_EL1809;
		public PlainEL1809_32157CFD Term_293_EL1809
		{
			get
			{
				return _Term_293_EL1809;
			}

			set
			{
				if (_Term_293_EL1809 != value)
				{
					_Term_293_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_293_EL1809)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_289_EK1100_9C677E50()
		{
			_Term_237_EK1122 = new PlainTerm_237_EK1122_86A8F7BD();
			_Term_293_EL1809 = new PlainEL1809_32157CFD();
		}
	}
}