using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_153_EK1100_91C0BB48 : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_154_EK1122_E57516AE _Term_154_EK1122;
		public PlainTerm_154_EK1122_E57516AE Term_154_EK1122
		{
			get
			{
				return _Term_154_EK1122;
			}

			set
			{
				if (_Term_154_EK1122 != value)
				{
					_Term_154_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_154_EK1122)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_155_EL2008;
		public PlainEL2008_E2806B95 Term_155_EL2008
		{
			get
			{
				return _Term_155_EL2008;
			}

			set
			{
				if (_Term_155_EL2008 != value)
				{
					_Term_155_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_155_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_156_EL2008;
		public PlainEL2008_E2806B95 Term_156_EL2008
		{
			get
			{
				return _Term_156_EL2008;
			}

			set
			{
				if (_Term_156_EL2008 != value)
				{
					_Term_156_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_156_EL2008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_153_EK1100_91C0BB48()
		{
			_Term_154_EK1122 = new PlainTerm_154_EK1122_E57516AE();
			_Term_155_EL2008 = new PlainEL2008_E2806B95();
			_Term_156_EL2008 = new PlainEL2008_E2806B95();
		}
	}
}