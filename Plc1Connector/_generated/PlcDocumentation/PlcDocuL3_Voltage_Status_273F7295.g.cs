using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L3_Voltage_Status_273F7295 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public U3_Status_DC903920 U3_Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L3_Voltage_Status_273F7295()
		{
		}
	}
#endif
}