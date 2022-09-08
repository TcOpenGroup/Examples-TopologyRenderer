using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L2_Voltage_Status_0D1813FE : PlcDocu.TcoIo.InputBase_8311D824
	{
		public U2_Status_DC903920 U2_Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L2_Voltage_Status_0D1813FE()
		{
		}
	}
#endif
}