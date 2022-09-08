using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL4004_E203F875 : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_1;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_2;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_3;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_4;
		public TcoIo.WcState_0B2B16F9 WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL4004_E203F875()
		{
		}
	}
#endif
}