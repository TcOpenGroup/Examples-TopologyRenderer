using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3773_F128CC82 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainL1_Voltage_Status_7371B043 _L1_Voltage_Status;
		public PlainL1_Voltage_Status_7371B043 L1_Voltage_Status
		{
			get
			{
				return _L1_Voltage_Status;
			}

			set
			{
				if (_L1_Voltage_Status != value)
				{
					_L1_Voltage_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L1_Voltage_Status)));
				}
			}
		}

		PlainL1_Voltage_Samples_41AEB7FF _L1_Voltage_Samples;
		public PlainL1_Voltage_Samples_41AEB7FF L1_Voltage_Samples
		{
			get
			{
				return _L1_Voltage_Samples;
			}

			set
			{
				if (_L1_Voltage_Samples != value)
				{
					_L1_Voltage_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L1_Voltage_Samples)));
				}
			}
		}

		PlainL1_Current_Status_82DECBF6 _L1_Current_Status;
		public PlainL1_Current_Status_82DECBF6 L1_Current_Status
		{
			get
			{
				return _L1_Current_Status;
			}

			set
			{
				if (_L1_Current_Status != value)
				{
					_L1_Current_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L1_Current_Status)));
				}
			}
		}

		PlainL1_Current_Samples_9EC08B3E _L1_Current_Samples;
		public PlainL1_Current_Samples_9EC08B3E L1_Current_Samples
		{
			get
			{
				return _L1_Current_Samples;
			}

			set
			{
				if (_L1_Current_Samples != value)
				{
					_L1_Current_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L1_Current_Samples)));
				}
			}
		}

		PlainL2_Voltage_Status_0D1813FE _L2_Voltage_Status;
		public PlainL2_Voltage_Status_0D1813FE L2_Voltage_Status
		{
			get
			{
				return _L2_Voltage_Status;
			}

			set
			{
				if (_L2_Voltage_Status != value)
				{
					_L2_Voltage_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L2_Voltage_Status)));
				}
			}
		}

		PlainL2_Voltage_Samples_75D833AF _L2_Voltage_Samples;
		public PlainL2_Voltage_Samples_75D833AF L2_Voltage_Samples
		{
			get
			{
				return _L2_Voltage_Samples;
			}

			set
			{
				if (_L2_Voltage_Samples != value)
				{
					_L2_Voltage_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L2_Voltage_Samples)));
				}
			}
		}

		PlainL2_Current_Status_FCB7684B _L2_Current_Status;
		public PlainL2_Current_Status_FCB7684B L2_Current_Status
		{
			get
			{
				return _L2_Current_Status;
			}

			set
			{
				if (_L2_Current_Status != value)
				{
					_L2_Current_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L2_Current_Status)));
				}
			}
		}

		PlainL2_Current_Samples_AAB60F6E _L2_Current_Samples;
		public PlainL2_Current_Samples_AAB60F6E L2_Current_Samples
		{
			get
			{
				return _L2_Current_Samples;
			}

			set
			{
				if (_L2_Current_Samples != value)
				{
					_L2_Current_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L2_Current_Samples)));
				}
			}
		}

		PlainL3_Voltage_Status_273F7295 _L3_Voltage_Status;
		public PlainL3_Voltage_Status_273F7295 L3_Voltage_Status
		{
			get
			{
				return _L3_Voltage_Status;
			}

			set
			{
				if (_L3_Voltage_Status != value)
				{
					_L3_Voltage_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L3_Voltage_Status)));
				}
			}
		}

		PlainL3_Voltage_Samples_660A4F9F _L3_Voltage_Samples;
		public PlainL3_Voltage_Samples_660A4F9F L3_Voltage_Samples
		{
			get
			{
				return _L3_Voltage_Samples;
			}

			set
			{
				if (_L3_Voltage_Samples != value)
				{
					_L3_Voltage_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L3_Voltage_Samples)));
				}
			}
		}

		PlainL3_Current_Status_D6900920 _L3_Current_Status;
		public PlainL3_Current_Status_D6900920 L3_Current_Status
		{
			get
			{
				return _L3_Current_Status;
			}

			set
			{
				if (_L3_Current_Status != value)
				{
					_L3_Current_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L3_Current_Status)));
				}
			}
		}

		PlainL3_Current_Samples_B964735E _L3_Current_Samples;
		public PlainL3_Current_Samples_B964735E L3_Current_Samples
		{
			get
			{
				return _L3_Current_Samples;
			}

			set
			{
				if (_L3_Current_Samples != value)
				{
					_L3_Current_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(L3_Current_Samples)));
				}
			}
		}

		PlainAI_NextSync1Time_6DC4D296 _AI_NextSync1Time;
		public PlainAI_NextSync1Time_6DC4D296 AI_NextSync1Time
		{
			get
			{
				return _AI_NextSync1Time;
			}

			set
			{
				if (_AI_NextSync1Time != value)
				{
					_AI_NextSync1Time = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_NextSync1Time)));
				}
			}
		}

		PlainAI_Sample_Count_EA88CAD9 _AI_Sample_Count;
		public PlainAI_Sample_Count_EA88CAD9 AI_Sample_Count
		{
			get
			{
				return _AI_Sample_Count;
			}

			set
			{
				if (_AI_Sample_Count != value)
				{
					_AI_Sample_Count = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_Sample_Count)));
				}
			}
		}

		TcoIo.PlainWcState_9091E0EB _WcState;
		public TcoIo.PlainWcState_9091E0EB WcState
		{
			get
			{
				return _WcState;
			}

			set
			{
				if (_WcState != value)
				{
					_WcState = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WcState)));
				}
			}
		}

		PlainInfoData_B84DBEC5 _InfoData;
		public PlainInfoData_B84DBEC5 InfoData
		{
			get
			{
				return _InfoData;
			}

			set
			{
				if (_InfoData != value)
				{
					_InfoData = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InfoData)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainEL3773_F128CC82()
		{
			_L1_Voltage_Status = new PlainL1_Voltage_Status_7371B043();
			_L1_Voltage_Samples = new PlainL1_Voltage_Samples_41AEB7FF();
			_L1_Current_Status = new PlainL1_Current_Status_82DECBF6();
			_L1_Current_Samples = new PlainL1_Current_Samples_9EC08B3E();
			_L2_Voltage_Status = new PlainL2_Voltage_Status_0D1813FE();
			_L2_Voltage_Samples = new PlainL2_Voltage_Samples_75D833AF();
			_L2_Current_Status = new PlainL2_Current_Status_FCB7684B();
			_L2_Current_Samples = new PlainL2_Current_Samples_AAB60F6E();
			_L3_Voltage_Status = new PlainL3_Voltage_Status_273F7295();
			_L3_Voltage_Samples = new PlainL3_Voltage_Samples_660A4F9F();
			_L3_Current_Status = new PlainL3_Current_Status_D6900920();
			_L3_Current_Samples = new PlainL3_Current_Samples_B964735E();
			_AI_NextSync1Time = new PlainAI_NextSync1Time_6DC4D296();
			_AI_Sample_Count = new PlainAI_Sample_Count_EA88CAD9();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new PlainInfoData_B84DBEC5();
		}
	}
}