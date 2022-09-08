using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL3773_F128CC82 : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public L1_Voltage_Status_7371B043 L1_Voltage_Status;
		public L1_Voltage_Samples_41AEB7FF L1_Voltage_Samples;
		public L1_Current_Status_82DECBF6 L1_Current_Status;
		public L1_Current_Samples_9EC08B3E L1_Current_Samples;
		public L2_Voltage_Status_0D1813FE L2_Voltage_Status;
		public L2_Voltage_Samples_75D833AF L2_Voltage_Samples;
		public L2_Current_Status_FCB7684B L2_Current_Status;
		public L2_Current_Samples_AAB60F6E L2_Current_Samples;
		public L3_Voltage_Status_273F7295 L3_Voltage_Status;
		public L3_Voltage_Samples_660A4F9F L3_Voltage_Samples;
		public L3_Current_Status_D6900920 L3_Current_Status;
		public L3_Current_Samples_B964735E L3_Current_Samples;
		public AI_NextSync1Time_6DC4D296 AI_NextSync1Time;
		public AI_Sample_Count_EA88CAD9 AI_Sample_Count;
		public TcoIo.WcState_9091E0EB WcState;
		public InfoData_B84DBEC5 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL3773_F128CC82()
		{
		}
	}
#endif
}