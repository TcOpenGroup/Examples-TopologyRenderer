using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L1_Voltage_Status_7371B043 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public U1_Status_DC903920 U1_Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L1_Voltage_Status_7371B043()
		{
		}
	}
#endif
}