using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainChannel_42CA91F7 : TcoIo.PlainOutputBase_10CEE7DE
	{
		System.Boolean _Output;
		public System.Boolean Output
		{
			get
			{
				return _Output;
			}

			set
			{
				if (_Output != value)
				{
					_Output = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainChannel_42CA91F7()
		{
		}
	}
}