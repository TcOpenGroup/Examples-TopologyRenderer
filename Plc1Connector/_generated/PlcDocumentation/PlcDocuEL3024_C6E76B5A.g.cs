using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL3024_C6E76B5A : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public AI_Standard_Channel_4A394481 AI_Standard_Channel_1;
		public AI_Standard_Channel_4A394481 AI_Standard_Channel_2;
		public AI_Standard_Channel_4A394481 AI_Standard_Channel_3;
		public AI_Standard_Channel_4A394481 AI_Standard_Channel_4;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL3024_C6E76B5A()
		{
		}
	}
#endif
}