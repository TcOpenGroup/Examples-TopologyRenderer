using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_178_EK1100_9B7E9852 : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_179_EK1122_2A33725A _Term_179_EK1122;
		public PlainTerm_179_EK1122_2A33725A Term_179_EK1122
		{
			get
			{
				return _Term_179_EK1122;
			}

			set
			{
				if (_Term_179_EK1122 != value)
				{
					_Term_179_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_179_EK1122)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_184_EL2008;
		public PlainEL2008_E2806B95 Term_184_EL2008
		{
			get
			{
				return _Term_184_EL2008;
			}

			set
			{
				if (_Term_184_EL2008 != value)
				{
					_Term_184_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_184_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_185_EL2008;
		public PlainEL2008_E2806B95 Term_185_EL2008
		{
			get
			{
				return _Term_185_EL2008;
			}

			set
			{
				if (_Term_185_EL2008 != value)
				{
					_Term_185_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_185_EL2008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_178_EK1100_9B7E9852()
		{
			_Term_179_EK1122 = new PlainTerm_179_EK1122_2A33725A();
			_Term_184_EL2008 = new PlainEL2008_E2806B95();
			_Term_185_EL2008 = new PlainEL2008_E2806B95();
		}
	}
}