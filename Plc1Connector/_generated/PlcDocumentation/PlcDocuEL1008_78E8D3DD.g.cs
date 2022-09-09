using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL1008_78E8D3DD : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public Channel_830843C1 Channel_1;
		public Channel_830843C1 Channel_2;
		public Channel_830843C1 Channel_3;
		public Channel_830843C1 Channel_4;
		public Channel_830843C1 Channel_5;
		public Channel_830843C1 Channel_6;
		public Channel_830843C1 Channel_7;
		public Channel_830843C1 Channel_8;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_6F19DB2B InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL1008_78E8D3DD()
		{
		}
	}
#endif
}