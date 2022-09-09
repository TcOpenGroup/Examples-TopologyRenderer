using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_23_EK1100_C1096874 : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_24_EK1122_39E7B5CB _Term_24_EK1122;
		public PlainTerm_24_EK1122_39E7B5CB Term_24_EK1122
		{
			get
			{
				return _Term_24_EK1122;
			}

			set
			{
				if (_Term_24_EK1122 != value)
				{
					_Term_24_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_24_EK1122)));
				}
			}
		}

		PlainEL3773_F128CC82 _Term_31_EL3773;
		public PlainEL3773_F128CC82 Term_31_EL3773
		{
			get
			{
				return _Term_31_EL3773;
			}

			set
			{
				if (_Term_31_EL3773 != value)
				{
					_Term_31_EL3773 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_31_EL3773)));
				}
			}
		}

		PlainEL2258_E3B260FA _Term_32_EL2258;
		public PlainEL2258_E3B260FA Term_32_EL2258
		{
			get
			{
				return _Term_32_EL2258;
			}

			set
			{
				if (_Term_32_EL2258 != value)
				{
					_Term_32_EL2258 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_32_EL2258)));
				}
			}
		}

		PlainEL3164_B71BFF42 _Term_33_EL3164;
		public PlainEL3164_B71BFF42 Term_33_EL3164
		{
			get
			{
				return _Term_33_EL3164;
			}

			set
			{
				if (_Term_33_EL3164 != value)
				{
					_Term_33_EL3164 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_33_EL3164)));
				}
			}
		}

		PlainEK1110_1FC0878B _Term_40_EK1110;
		public PlainEK1110_1FC0878B Term_40_EK1110
		{
			get
			{
				return _Term_40_EK1110;
			}

			set
			{
				if (_Term_40_EK1110 != value)
				{
					_Term_40_EK1110 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_40_EK1110)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_23_EK1100_C1096874()
		{
			_Term_24_EK1122 = new PlainTerm_24_EK1122_39E7B5CB();
			_Term_31_EL3773 = new PlainEL3773_F128CC82();
			_Term_32_EL2258 = new PlainEL2258_E3B260FA();
			_Term_33_EL3164 = new PlainEL3164_B71BFF42();
			_Term_40_EK1110 = new PlainEK1110_1FC0878B();
		}
	}
}