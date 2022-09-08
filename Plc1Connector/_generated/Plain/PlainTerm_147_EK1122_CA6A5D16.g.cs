using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_147_EK1122_CA6A5D16 : Plc1.PlainEK1122_1FC0878B
	{
		PlainTerm_153_EK1100_91C0BB48 _Term_153_EK1100;
		public PlainTerm_153_EK1100_91C0BB48 Term_153_EK1100
		{
			get
			{
				return _Term_153_EK1100;
			}

			set
			{
				if (_Term_153_EK1100 != value)
				{
					_Term_153_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_153_EK1100)));
				}
			}
		}

		PlainTerm_178_EK1100_9B7E9852 _Term_178_EK1100;
		public PlainTerm_178_EK1100_9B7E9852 Term_178_EK1100
		{
			get
			{
				return _Term_178_EK1100;
			}

			set
			{
				if (_Term_178_EK1100 != value)
				{
					_Term_178_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_178_EK1100)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_147_EK1122_CA6A5D16()
		{
			_Term_153_EK1100 = new PlainTerm_153_EK1100_91C0BB48();
			_Term_178_EK1100 = new PlainTerm_178_EK1100_9B7E9852();
		}
	}
}