using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_1_EK1200_B38DC9A8 : Plc1.PlainEK1200_013D0B49
	{
		PlainEL6002_CD897635 _Term_2_EL6002;
		public PlainEL6002_CD897635 Term_2_EL6002
		{
			get
			{
				return _Term_2_EL6002;
			}

			set
			{
				if (_Term_2_EL6002 != value)
				{
					_Term_2_EL6002 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_2_EL6002)));
				}
			}
		}

		PlainEL1809_32157CFD _Term_3_EL1809;
		public PlainEL1809_32157CFD Term_3_EL1809
		{
			get
			{
				return _Term_3_EL1809;
			}

			set
			{
				if (_Term_3_EL1809 != value)
				{
					_Term_3_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_3_EL1809)));
				}
			}
		}

		PlainEL2809_2B6483BD _Term_4_EL2809;
		public PlainEL2809_2B6483BD Term_4_EL2809
		{
			get
			{
				return _Term_4_EL2809;
			}

			set
			{
				if (_Term_4_EL2809 != value)
				{
					_Term_4_EL2809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_4_EL2809)));
				}
			}
		}

		PlainEL4004_E203F875 _Term_5_EL4004;
		public PlainEL4004_E203F875 Term_5_EL4004
		{
			get
			{
				return _Term_5_EL4004;
			}

			set
			{
				if (_Term_5_EL4004 != value)
				{
					_Term_5_EL4004 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_5_EL4004)));
				}
			}
		}

		PlainEL2809_2B6483BD _Term_6_EL2809;
		public PlainEL2809_2B6483BD Term_6_EL2809
		{
			get
			{
				return _Term_6_EL2809;
			}

			set
			{
				if (_Term_6_EL2809 != value)
				{
					_Term_6_EL2809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_6_EL2809)));
				}
			}
		}

		PlainEL6001_0DE01E7E _Term_7_EL6001;
		public PlainEL6001_0DE01E7E Term_7_EL6001
		{
			get
			{
				return _Term_7_EL6001;
			}

			set
			{
				if (_Term_7_EL6001 != value)
				{
					_Term_7_EL6001 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_7_EL6001)));
				}
			}
		}

		PlainEL9011_D65D3D32 _Term_8_EL9011;
		public PlainEL9011_D65D3D32 Term_8_EL9011
		{
			get
			{
				return _Term_8_EL9011;
			}

			set
			{
				if (_Term_8_EL9011 != value)
				{
					_Term_8_EL9011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_8_EL9011)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_1_EK1200_B38DC9A8()
		{
			_Term_2_EL6002 = new PlainEL6002_CD897635();
			_Term_3_EL1809 = new PlainEL1809_32157CFD();
			_Term_4_EL2809 = new PlainEL2809_2B6483BD();
			_Term_5_EL4004 = new PlainEL4004_E203F875();
			_Term_6_EL2809 = new PlainEL2809_2B6483BD();
			_Term_7_EL6001 = new PlainEL6001_0DE01E7E();
			_Term_8_EL9011 = new PlainEL9011_D65D3D32();
		}
	}
}