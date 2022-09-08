using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_288_EK1122_18F8921F : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_289_EK1100_9C677E50 _Term_289_EK1100;
		public PlainTerm_289_EK1100_9C677E50 Term_289_EK1100
		{
			get
			{
				return _Term_289_EK1100;
			}

			set
			{
				if (_Term_289_EK1100 != value)
				{
					_Term_289_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_289_EK1100)));
				}
			}
		}

		PlainTerm_294_EK1100_DFE2A59E _Term_294_EK1100;
		public PlainTerm_294_EK1100_DFE2A59E Term_294_EK1100
		{
			get
			{
				return _Term_294_EK1100;
			}

			set
			{
				if (_Term_294_EK1100 != value)
				{
					_Term_294_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_294_EK1100)));
				}
			}
		}

		PlainTerm_307_EK1100_EB8FAA41 _Term_307_EK1100;
		public PlainTerm_307_EK1100_EB8FAA41 Term_307_EK1100
		{
			get
			{
				return _Term_307_EK1100;
			}

			set
			{
				if (_Term_307_EK1100 != value)
				{
					_Term_307_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_307_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_288_EK1122_18F8921F()
		{
			_Term_289_EK1100 = new PlainTerm_289_EK1100_9C677E50();
			_Term_294_EK1100 = new PlainTerm_294_EK1100_DFE2A59E();
			_Term_307_EK1100 = new PlainTerm_307_EK1100_EB8FAA41();
		}
	}
}