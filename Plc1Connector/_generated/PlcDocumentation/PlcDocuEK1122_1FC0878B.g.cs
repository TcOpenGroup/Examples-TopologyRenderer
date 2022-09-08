using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EK1122_1FC0878B : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public TcoIo.InfoData_6F19DB2B InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EK1122_1FC0878B()
		{
		}
	}
#endif
}