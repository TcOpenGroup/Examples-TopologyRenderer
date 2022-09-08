using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_11_EK1100_B6553301 : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL3174_B71BFF42 _Term_12_EL3174_0002;
		public PlainEL3174_B71BFF42 Term_12_EL3174_0002
		{
			get
			{
				return _Term_12_EL3174_0002;
			}

			set
			{
				if (_Term_12_EL3174_0002 != value)
				{
					_Term_12_EL3174_0002 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_12_EL3174_0002)));
				}
			}
		}

		PlainEL6001_0DE01E7E _Term_13_EL6001;
		public PlainEL6001_0DE01E7E Term_13_EL6001
		{
			get
			{
				return _Term_13_EL6001;
			}

			set
			{
				if (_Term_13_EL6001 != value)
				{
					_Term_13_EL6001 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_13_EL6001)));
				}
			}
		}

		PlainEL3011_7A495228 _Term_14_EL3011;
		public PlainEL3011_7A495228 Term_14_EL3011
		{
			get
			{
				return _Term_14_EL3011;
			}

			set
			{
				if (_Term_14_EL3011 != value)
				{
					_Term_14_EL3011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_14_EL3011)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_15_EL2008;
		public PlainEL2008_E2806B95 Term_15_EL2008
		{
			get
			{
				return _Term_15_EL2008;
			}

			set
			{
				if (_Term_15_EL2008 != value)
				{
					_Term_15_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_15_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_16_EL2008;
		public PlainEL2008_E2806B95 Term_16_EL2008
		{
			get
			{
				return _Term_16_EL2008;
			}

			set
			{
				if (_Term_16_EL2008 != value)
				{
					_Term_16_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_16_EL2008)));
				}
			}
		}

		PlainEK1110_1FC0878B _Term_17_EK1110;
		public PlainEK1110_1FC0878B Term_17_EK1110
		{
			get
			{
				return _Term_17_EK1110;
			}

			set
			{
				if (_Term_17_EK1110 != value)
				{
					_Term_17_EK1110 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_17_EK1110)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_11_EK1100_B6553301()
		{
			_Term_12_EL3174_0002 = new PlainEL3174_B71BFF42();
			_Term_13_EL6001 = new PlainEL6001_0DE01E7E();
			_Term_14_EL3011 = new PlainEL3011_7A495228();
			_Term_15_EL2008 = new PlainEL2008_E2806B95();
			_Term_16_EL2008 = new PlainEL2008_E2806B95();
			_Term_17_EK1110 = new PlainEK1110_1FC0878B();
		}
	}
}