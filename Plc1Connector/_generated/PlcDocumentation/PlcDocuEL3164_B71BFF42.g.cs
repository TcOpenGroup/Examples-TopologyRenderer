using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL3164_B71BFF42 : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_1;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_2;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_3;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_4;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL3164_B71BFF42()
		{
		}
	}
#endif
}