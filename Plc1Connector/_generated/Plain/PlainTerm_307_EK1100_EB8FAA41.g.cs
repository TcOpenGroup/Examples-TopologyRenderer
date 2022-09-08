using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_307_EK1100_EB8FAA41 : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_330_EK1122_0EDE60FE _Term_330_EK1122;
		public PlainTerm_330_EK1122_0EDE60FE Term_330_EK1122
		{
			get
			{
				return _Term_330_EK1122;
			}

			set
			{
				if (_Term_330_EK1122 != value)
				{
					_Term_330_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_330_EK1122)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_335_EL2008;
		public PlainEL2008_E2806B95 Term_335_EL2008
		{
			get
			{
				return _Term_335_EL2008;
			}

			set
			{
				if (_Term_335_EL2008 != value)
				{
					_Term_335_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_335_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_336_EL2008;
		public PlainEL2008_E2806B95 Term_336_EL2008
		{
			get
			{
				return _Term_336_EL2008;
			}

			set
			{
				if (_Term_336_EL2008 != value)
				{
					_Term_336_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_336_EL2008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_307_EK1100_EB8FAA41()
		{
			_Term_330_EK1122 = new PlainTerm_330_EK1122_0EDE60FE();
			_Term_335_EL2008 = new PlainEL2008_E2806B95();
			_Term_336_EL2008 = new PlainEL2008_E2806B95();
		}
	}
}