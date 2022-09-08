using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D : TcoIo.PlainOutputBase_10CEE7DE
	{
		PlainCtrl_1EFB4D3B _Ctrl;
		public PlainCtrl_1EFB4D3B Ctrl
		{
			get
			{
				return _Ctrl;
			}

			set
			{
				if (_Ctrl != value)
				{
					_Ctrl = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Ctrl)));
				}
			}
		}

		public System.Byte[] Data_Out
		{
			get;
			set;
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D()
		{
			_Ctrl = new PlainCtrl_1EFB4D3B();
			Data_Out = new System.Byte[22];
		}
	}
}