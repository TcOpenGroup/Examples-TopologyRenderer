using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_25_EK1100_08217EB4 : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1819_32157CFD _Term_26_EL1819;
		public PlainEL1819_32157CFD Term_26_EL1819
		{
			get
			{
				return _Term_26_EL1819;
			}

			set
			{
				if (_Term_26_EL1819 != value)
				{
					_Term_26_EL1819 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_26_EL1819)));
				}
			}
		}

		PlainEL1819_32157CFD _Term_27_EL1819;
		public PlainEL1819_32157CFD Term_27_EL1819
		{
			get
			{
				return _Term_27_EL1819;
			}

			set
			{
				if (_Term_27_EL1819 != value)
				{
					_Term_27_EL1819 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_27_EL1819)));
				}
			}
		}

		PlainEL9011_D65D3D32 _Term_30_EL9011;
		public PlainEL9011_D65D3D32 Term_30_EL9011
		{
			get
			{
				return _Term_30_EL9011;
			}

			set
			{
				if (_Term_30_EL9011 != value)
				{
					_Term_30_EL9011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_30_EL9011)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_25_EK1100_08217EB4()
		{
			_Term_26_EL1819 = new PlainEL1819_32157CFD();
			_Term_27_EL1819 = new PlainEL1819_32157CFD();
			_Term_30_EL9011 = new PlainEL9011_D65D3D32();
		}
	}
}