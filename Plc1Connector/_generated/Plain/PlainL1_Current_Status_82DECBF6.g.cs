using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Current_Status_82DECBF6 : TcoIo.PlainInputBase_8311D824
	{
		PlainI1_Status_DC903920 _I1_Status;
		public PlainI1_Status_DC903920 I1_Status
		{
			get
			{
				return _I1_Status;
			}

			set
			{
				if (_I1_Status != value)
				{
					_I1_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I1_Status)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL1_Current_Status_82DECBF6()
		{
			_I1_Status = new PlainI1_Status_DC903920();
		}
	}
}