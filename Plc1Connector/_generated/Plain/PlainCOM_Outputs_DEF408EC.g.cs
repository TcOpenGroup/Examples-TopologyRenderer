using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCOM_Outputs_DEF408EC : TcoIo.PlainOutputBase_10CEE7DE
	{
		PlainCtrl_71604E86 _Ctrl;
		public PlainCtrl_71604E86 Ctrl
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
		public PlainCOM_Outputs_DEF408EC()
		{
			_Ctrl = new PlainCtrl_71604E86();
			Data_Out = new System.Byte[22];
		}
	}
}