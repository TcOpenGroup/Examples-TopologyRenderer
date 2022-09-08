using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_23_EK1100_DFBF0BE4 : Plc1.PlainEK1100_1FC0878B
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

		PlainEL9011_D65D3D32 _Term_32_EL9011;
		public PlainEL9011_D65D3D32 Term_32_EL9011
		{
			get
			{
				return _Term_32_EL9011;
			}

			set
			{
				if (_Term_32_EL9011 != value)
				{
					_Term_32_EL9011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_32_EL9011)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_23_EK1100_DFBF0BE4()
		{
			_Term_24_EK1122 = new PlainTerm_24_EK1122_39E7B5CB();
			_Term_31_EL3773 = new PlainEL3773_F128CC82();
			_Term_32_EL2258 = new PlainEL2258_E3B260FA();
			_Term_33_EL3164 = new PlainEL3164_B71BFF42();
			_Term_32_EL9011 = new PlainEL9011_D65D3D32();
		}
	}
}