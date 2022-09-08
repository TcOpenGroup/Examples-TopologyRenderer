using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL6002_CD897635 : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public COM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_1;
		public COM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_2;
		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_1;
		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_2;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL6002_CD897635()
		{
		}
	}
#endif
}