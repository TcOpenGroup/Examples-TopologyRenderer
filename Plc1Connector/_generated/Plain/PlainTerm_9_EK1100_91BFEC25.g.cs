using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_9_EK1100_91BFEC25 : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_10_EK1122_3D069EC1 _Term_10_EK1122;
		public PlainTerm_10_EK1122_3D069EC1 Term_10_EK1122
		{
			get
			{
				return _Term_10_EK1122;
			}

			set
			{
				if (_Term_10_EK1122 != value)
				{
					_Term_10_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_10_EK1122)));
				}
			}
		}

		PlainEL3403_812980A6 _Term_34_EL3403;
		public PlainEL3403_812980A6 Term_34_EL3403
		{
			get
			{
				return _Term_34_EL3403;
			}

			set
			{
				if (_Term_34_EL3403 != value)
				{
					_Term_34_EL3403 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_34_EL3403)));
				}
			}
		}

		PlainEL6001_0DE01E7E _Term_35_EL6001;
		public PlainEL6001_0DE01E7E Term_35_EL6001
		{
			get
			{
				return _Term_35_EL6001;
			}

			set
			{
				if (_Term_35_EL6001 != value)
				{
					_Term_35_EL6001 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_35_EL6001)));
				}
			}
		}

		PlainEL3024_C6E76B5A _Term_36_EL3024;
		public PlainEL3024_C6E76B5A Term_36_EL3024
		{
			get
			{
				return _Term_36_EL3024;
			}

			set
			{
				if (_Term_36_EL3024 != value)
				{
					_Term_36_EL3024 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_36_EL3024)));
				}
			}
		}

		PlainEL9011_D65D3D32 _Term_33_EL9011;
		public PlainEL9011_D65D3D32 Term_33_EL9011
		{
			get
			{
				return _Term_33_EL9011;
			}

			set
			{
				if (_Term_33_EL9011 != value)
				{
					_Term_33_EL9011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_33_EL9011)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_9_EK1100_91BFEC25()
		{
			_Term_10_EK1122 = new PlainTerm_10_EK1122_3D069EC1();
			_Term_34_EL3403 = new PlainEL3403_812980A6();
			_Term_35_EL6001 = new PlainEL6001_0DE01E7E();
			_Term_36_EL3024 = new PlainEL3024_C6E76B5A();
			_Term_33_EL9011 = new PlainEL9011_D65D3D32();
		}
	}
}