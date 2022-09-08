using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_18_EK1100_20659A8D : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_19_EL1809;
		public PlainEL1809_32157CFD Term_19_EL1809
		{
			get
			{
				return _Term_19_EL1809;
			}

			set
			{
				if (_Term_19_EL1809 != value)
				{
					_Term_19_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_19_EL1809)));
				}
			}
		}

		PlainEL2809_2B6483BD _Term_20_EL2809;
		public PlainEL2809_2B6483BD Term_20_EL2809
		{
			get
			{
				return _Term_20_EL2809;
			}

			set
			{
				if (_Term_20_EL2809 != value)
				{
					_Term_20_EL2809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_20_EL2809)));
				}
			}
		}

		PlainEL1809_32157CFD _Term_21_EL1809;
		public PlainEL1809_32157CFD Term_21_EL1809
		{
			get
			{
				return _Term_21_EL1809;
			}

			set
			{
				if (_Term_21_EL1809 != value)
				{
					_Term_21_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_21_EL1809)));
				}
			}
		}

		PlainEL3011_7A495228 _Term_22_EL3011;
		public PlainEL3011_7A495228 Term_22_EL3011
		{
			get
			{
				return _Term_22_EL3011;
			}

			set
			{
				if (_Term_22_EL3011 != value)
				{
					_Term_22_EL3011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_22_EL3011)));
				}
			}
		}

		PlainEL9011_D65D3D32 _Term_29_EL9011;
		public PlainEL9011_D65D3D32 Term_29_EL9011
		{
			get
			{
				return _Term_29_EL9011;
			}

			set
			{
				if (_Term_29_EL9011 != value)
				{
					_Term_29_EL9011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_29_EL9011)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_18_EK1100_20659A8D()
		{
			_Term_19_EL1809 = new PlainEL1809_32157CFD();
			_Term_20_EL2809 = new PlainEL2809_2B6483BD();
			_Term_21_EL1809 = new PlainEL1809_32157CFD();
			_Term_22_EL3011 = new PlainEL3011_7A495228();
			_Term_29_EL9011 = new PlainEL9011_D65D3D32();
		}
	}
}