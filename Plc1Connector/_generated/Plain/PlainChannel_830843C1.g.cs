using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainChannel_830843C1 : TcoIo.PlainInputBase_8311D824
	{
		System.Boolean _Input;
		public System.Boolean Input
		{
			get
			{
				return _Input;
			}

			set
			{
				if (_Input != value)
				{
					_Input = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Input)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainChannel_830843C1()
		{
		}
	}
}