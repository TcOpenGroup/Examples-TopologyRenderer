using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL3403_812980A6 : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public PM_Inputs_Channel_2F868086 PM_Inputs_Channel_1;
		public PM_Inputs_Channel_2F868086 PM_Inputs_Channel_2;
		public PM_Inputs_Channel_2F868086 PM_Inputs_Channel_3;
		public PM_Status_data_2A9514CB PM_Status_data;
		public PM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_1;
		public PM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_2;
		public PM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_3;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL3403_812980A6()
		{
		}
	}
#endif
}