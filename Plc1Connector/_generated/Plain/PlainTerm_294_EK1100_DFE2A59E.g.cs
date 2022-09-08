using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_294_EK1100_DFE2A59E : Plc1.PlainEK1100_1FC0878B
	{
		PlainEL1809_32157CFD _Term_300_EL1809;
		public PlainEL1809_32157CFD Term_300_EL1809
		{
			get
			{
				return _Term_300_EL1809;
			}

			set
			{
				if (_Term_300_EL1809 != value)
				{
					_Term_300_EL1809 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_300_EL1809)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_304_EL2008;
		public PlainEL2008_E2806B95 Term_304_EL2008
		{
			get
			{
				return _Term_304_EL2008;
			}

			set
			{
				if (_Term_304_EL2008 != value)
				{
					_Term_304_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_304_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_305_EL2008;
		public PlainEL2008_E2806B95 Term_305_EL2008
		{
			get
			{
				return _Term_305_EL2008;
			}

			set
			{
				if (_Term_305_EL2008 != value)
				{
					_Term_305_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_305_EL2008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_294_EK1100_DFE2A59E()
		{
			_Term_300_EL1809 = new PlainEL1809_32157CFD();
			_Term_304_EL2008 = new PlainEL2008_E2806B95();
			_Term_305_EL2008 = new PlainEL2008_E2806B95();
		}
	}
}