using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Voltage_Status_0D1813FE : TcoIo.PlainInputBase_8311D824
	{
		PlainU2_Status_DC903920 _U2_Status;
		public PlainU2_Status_DC903920 U2_Status
		{
			get
			{
				return _U2_Status;
			}

			set
			{
				if (_U2_Status != value)
				{
					_U2_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(U2_Status)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL2_Voltage_Status_0D1813FE()
		{
			_U2_Status = new PlainU2_Status_DC903920();
		}
	}
}