using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3164_B71BFF42 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainAI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_1;
		public PlainAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_1
		{
			get
			{
				return _AI_Standard_Channel_1;
			}

			set
			{
				if (_AI_Standard_Channel_1 != value)
				{
					_AI_Standard_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_Standard_Channel_1)));
				}
			}
		}

		PlainAI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_2;
		public PlainAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_2
		{
			get
			{
				return _AI_Standard_Channel_2;
			}

			set
			{
				if (_AI_Standard_Channel_2 != value)
				{
					_AI_Standard_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_Standard_Channel_2)));
				}
			}
		}

		PlainAI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_3;
		public PlainAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_3
		{
			get
			{
				return _AI_Standard_Channel_3;
			}

			set
			{
				if (_AI_Standard_Channel_3 != value)
				{
					_AI_Standard_Channel_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_Standard_Channel_3)));
				}
			}
		}

		PlainAI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_4;
		public PlainAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_4
		{
			get
			{
				return _AI_Standard_Channel_4;
			}

			set
			{
				if (_AI_Standard_Channel_4 != value)
				{
					_AI_Standard_Channel_4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_Standard_Channel_4)));
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

		TcoIo.PlainInfoData_23CBA837 _InfoData;
		public TcoIo.PlainInfoData_23CBA837 InfoData
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
		public PlainEL3164_B71BFF42()
		{
			_AI_Standard_Channel_1 = new PlainAI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_2 = new PlainAI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_3 = new PlainAI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_4 = new PlainAI_Standard_Channel_A8DF64E3();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new TcoIo.PlainInfoData_23CBA837();
		}
	}
}