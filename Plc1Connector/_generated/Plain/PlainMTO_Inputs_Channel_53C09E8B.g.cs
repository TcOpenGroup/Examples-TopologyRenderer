using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMTO_Inputs_Channel_53C09E8B : TcoIo.PlainInputBase_8311D824
	{
		PlainStatus_642C2ED1 _Status;
		public PlainStatus_642C2ED1 Status
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

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMTO_Inputs_Channel_53C09E8B()
		{
			_Status = new PlainStatus_642C2ED1();
		}
	}
}