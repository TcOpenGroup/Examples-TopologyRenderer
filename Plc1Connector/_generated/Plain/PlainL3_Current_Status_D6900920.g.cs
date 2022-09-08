using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Current_Status_D6900920 : TcoIo.PlainInputBase_8311D824
	{
		PlainI3_Status_DC903920 _I3_Status;
		public PlainI3_Status_DC903920 I3_Status
		{
			get
			{
				return _I3_Status;
			}

			set
			{
				if (_I3_Status != value)
				{
					_I3_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I3_Status)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL3_Current_Status_D6900920()
		{
			_I3_Status = new PlainI3_Status_DC903920();
		}
	}
}