using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Current_Status_FCB7684B : TcoIo.PlainInputBase_8311D824
	{
		PlainI2_Status_DC903920 _I2_Status;
		public PlainI2_Status_DC903920 I2_Status
		{
			get
			{
				return _I2_Status;
			}

			set
			{
				if (_I2_Status != value)
				{
					_I2_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I2_Status)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL2_Current_Status_FCB7684B()
		{
			_I2_Status = new PlainI2_Status_DC903920();
		}
	}
}