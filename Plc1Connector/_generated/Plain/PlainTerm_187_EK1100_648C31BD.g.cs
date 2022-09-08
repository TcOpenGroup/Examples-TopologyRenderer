using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_187_EK1100_648C31BD : Plc1.PlainEK1100_1FC0878B
	{
		PlainTerm_188_EK1122_78D8AA43 _Term_188_EK1122;
		public PlainTerm_188_EK1122_78D8AA43 Term_188_EK1122
		{
			get
			{
				return _Term_188_EK1122;
			}

			set
			{
				if (_Term_188_EK1122 != value)
				{
					_Term_188_EK1122 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_188_EK1122)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_204_EL2008;
		public PlainEL2008_E2806B95 Term_204_EL2008
		{
			get
			{
				return _Term_204_EL2008;
			}

			set
			{
				if (_Term_204_EL2008 != value)
				{
					_Term_204_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_204_EL2008)));
				}
			}
		}

		PlainEL2008_E2806B95 _Term_205_EL2008;
		public PlainEL2008_E2806B95 Term_205_EL2008
		{
			get
			{
				return _Term_205_EL2008;
			}

			set
			{
				if (_Term_205_EL2008 != value)
				{
					_Term_205_EL2008 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_205_EL2008)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_187_EK1100_648C31BD()
		{
			_Term_188_EK1122 = new PlainTerm_188_EK1122_78D8AA43();
			_Term_204_EL2008 = new PlainEL2008_E2806B95();
			_Term_205_EL2008 = new PlainEL2008_E2806B95();
		}
	}
}