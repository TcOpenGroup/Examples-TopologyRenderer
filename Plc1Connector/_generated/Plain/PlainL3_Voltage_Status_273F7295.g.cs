using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Voltage_Status_273F7295 : TcoIo.PlainInputBase_8311D824
	{
		PlainU3_Status_DC903920 _U3_Status;
		public PlainU3_Status_DC903920 U3_Status
		{
			get
			{
				return _U3_Status;
			}

			set
			{
				if (_U3_Status != value)
				{
					_U3_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(U3_Status)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL3_Voltage_Status_273F7295()
		{
			_U3_Status = new PlainU3_Status_DC903920();
		}
	}
}