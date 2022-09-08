using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCOM_Inputs_3801C95E : TcoIo.PlainInputBase_8311D824
	{
		PlainStatus_3D84275F _Status;
		public PlainStatus_3D84275F Status
		{
			get
			{
				return _Status;
			}

			set
			{
				if (_Status != value)
				{
					_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Status)));
				}
			}
		}

		public System.Byte[] Data_In
		{
			get;
			set;
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainCOM_Inputs_3801C95E()
		{
			_Status = new PlainStatus_3D84275F();
			Data_In = new System.Byte[22];
		}
	}
}