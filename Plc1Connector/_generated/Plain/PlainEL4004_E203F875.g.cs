using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL4004_E203F875 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainAO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_1;
		public PlainAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_1
		{
			get
			{
				return _AO_Outputs_Channel_1;
			}

			set
			{
				if (_AO_Outputs_Channel_1 != value)
				{
					_AO_Outputs_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AO_Outputs_Channel_1)));
				}
			}
		}

		PlainAO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_2;
		public PlainAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_2
		{
			get
			{
				return _AO_Outputs_Channel_2;
			}

			set
			{
				if (_AO_Outputs_Channel_2 != value)
				{
					_AO_Outputs_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AO_Outputs_Channel_2)));
				}
			}
		}

		PlainAO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_3;
		public PlainAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_3
		{
			get
			{
				return _AO_Outputs_Channel_3;
			}

			set
			{
				if (_AO_Outputs_Channel_3 != value)
				{
					_AO_Outputs_Channel_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AO_Outputs_Channel_3)));
				}
			}
		}

		PlainAO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_4;
		public PlainAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_4
		{
			get
			{
				return _AO_Outputs_Channel_4;
			}

			set
			{
				if (_AO_Outputs_Channel_4 != value)
				{
					_AO_Outputs_Channel_4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AO_Outputs_Channel_4)));
				}
			}
		}

		TcoIo.PlainWcState_0B2B16F9 _WcState;
		public TcoIo.PlainWcState_0B2B16F9 WcState
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
		public PlainEL4004_E203F875()
		{
			_AO_Outputs_Channel_1 = new PlainAO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_2 = new PlainAO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_3 = new PlainAO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_4 = new PlainAO_Output_Channel_BA7EBB7C();
			_WcState = new TcoIo.PlainWcState_0B2B16F9();
			_InfoData = new TcoIo.PlainInfoData_23CBA837();
		}
	}
}