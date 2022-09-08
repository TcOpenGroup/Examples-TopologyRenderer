using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Voltage_Status_7371B043 : TcoIo.PlainInputBase_8311D824
	{
		PlainU1_Status_DC903920 _U1_Status;
		public PlainU1_Status_DC903920 U1_Status
		{
			get
			{
				return _U1_Status;
			}

			set
			{
				if (_U1_Status != value)
				{
					_U1_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(U1_Status)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL1_Voltage_Status_7371B043()
		{
			_U1_Status = new PlainU1_Status_DC903920();
		}
	}
}