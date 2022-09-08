using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL6002_CD897635 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainCOM_TxPDO_Map_Inputs_Channel_3801C95E _COM_TxPDO_Map_Inputs_Channel_1;
		public PlainCOM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_1
		{
			get
			{
				return _COM_TxPDO_Map_Inputs_Channel_1;
			}

			set
			{
				if (_COM_TxPDO_Map_Inputs_Channel_1 != value)
				{
					_COM_TxPDO_Map_Inputs_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(COM_TxPDO_Map_Inputs_Channel_1)));
				}
			}
		}

		PlainCOM_TxPDO_Map_Inputs_Channel_3801C95E _COM_TxPDO_Map_Inputs_Channel_2;
		public PlainCOM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_2
		{
			get
			{
				return _COM_TxPDO_Map_Inputs_Channel_2;
			}

			set
			{
				if (_COM_TxPDO_Map_Inputs_Channel_2 != value)
				{
					_COM_TxPDO_Map_Inputs_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(COM_TxPDO_Map_Inputs_Channel_2)));
				}
			}
		}

		PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D _COM_RxPDO_Map_Outputs_Channel_1;
		public PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_1
		{
			get
			{
				return _COM_RxPDO_Map_Outputs_Channel_1;
			}

			set
			{
				if (_COM_RxPDO_Map_Outputs_Channel_1 != value)
				{
					_COM_RxPDO_Map_Outputs_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(COM_RxPDO_Map_Outputs_Channel_1)));
				}
			}
		}

		PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D _COM_RxPDO_Map_Outputs_Channel_2;
		public PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_2
		{
			get
			{
				return _COM_RxPDO_Map_Outputs_Channel_2;
			}

			set
			{
				if (_COM_RxPDO_Map_Outputs_Channel_2 != value)
				{
					_COM_RxPDO_Map_Outputs_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(COM_RxPDO_Map_Outputs_Channel_2)));
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
		public PlainEL6002_CD897635()
		{
			_COM_TxPDO_Map_Inputs_Channel_1 = new PlainCOM_TxPDO_Map_Inputs_Channel_3801C95E();
			_COM_TxPDO_Map_Inputs_Channel_2 = new PlainCOM_TxPDO_Map_Inputs_Channel_3801C95E();
			_COM_RxPDO_Map_Outputs_Channel_1 = new PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D();
			_COM_RxPDO_Map_Outputs_Channel_2 = new PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new TcoIo.PlainInfoData_23CBA837();
		}
	}
}