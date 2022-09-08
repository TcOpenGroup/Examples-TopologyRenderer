using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3011_7A495228 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainAI_Standard_Channel_4A394481 _AI_Standard;
		public PlainAI_Standard_Channel_4A394481 AI_Standard
		{
			get
			{
				return _AI_Standard;
			}

			set
			{
				if (_AI_Standard != value)
				{
					_AI_Standard = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AI_Standard)));
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
		public PlainEL3011_7A495228()
		{
			_AI_Standard = new PlainAI_Standard_Channel_4A394481();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new TcoIo.PlainInfoData_23CBA837();
		}
	}
}