using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL3011_7A495228 : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public AI_Standard_Channel_4A394481 AI_Standard;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL3011_7A495228()
		{
		}
	}
#endif
}