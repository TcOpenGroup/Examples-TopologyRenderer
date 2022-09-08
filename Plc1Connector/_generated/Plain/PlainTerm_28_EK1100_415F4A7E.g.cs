using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_28_EK1100_415F4A7E : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL2788_E2806B95 _Term_29_EL2788;
		public PlainEL2788_E2806B95 Term_29_EL2788
		{
			get
			{
				return _Term_29_EL2788;
			}

			set
			{
				if (_Term_29_EL2788 != value)
				{
					_Term_29_EL2788 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_29_EL2788)));
				}
			}
		}

		PlainEL3773_F128CC82 _Term_30_EL3773;
		public PlainEL3773_F128CC82 Term_30_EL3773
		{
			get
			{
				return _Term_30_EL3773;
			}

			set
			{
				if (_Term_30_EL3773 != value)
				{
					_Term_30_EL3773 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_30_EL3773)));
				}
			}
		}

		PlainEL9011_D65D3D32 _Term_31_EL9011;
		public PlainEL9011_D65D3D32 Term_31_EL9011
		{
			get
			{
				return _Term_31_EL9011;
			}

			set
			{
				if (_Term_31_EL9011 != value)
				{
					_Term_31_EL9011 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_31_EL9011)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_28_EK1100_415F4A7E()
		{
			_Term_29_EL2788 = new PlainEL2788_E2806B95();
			_Term_30_EL3773 = new PlainEL3773_F128CC82();
			_Term_31_EL9011 = new PlainEL9011_D65D3D32();
		}
	}
}