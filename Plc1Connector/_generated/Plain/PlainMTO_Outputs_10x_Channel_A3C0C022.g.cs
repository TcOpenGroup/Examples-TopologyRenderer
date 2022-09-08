using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMTO_Outputs_10x_Channel_A3C0C022 : TcoIo.PlainOutputBase_10CEE7DE
	{
		PlainCtrl_77460BD3 _Ctrl;
		public PlainCtrl_77460BD3 Ctrl
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

		PlainOutputs_A910484D _Outputs;
		public PlainOutputs_A910484D Outputs
		{
			get
			{
				return _Outputs;
			}

			set
			{
				if (_Outputs != value)
				{
					_Outputs = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Outputs)));
				}
			}
		}

		public System.UInt32[] Output_event_time
		{
			get;
			set;
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMTO_Outputs_10x_Channel_A3C0C022()
		{
			_Ctrl = new PlainCtrl_77460BD3();
			_Outputs = new PlainOutputs_A910484D();
			Output_event_time = new System.UInt32[10];
		}
	}
}