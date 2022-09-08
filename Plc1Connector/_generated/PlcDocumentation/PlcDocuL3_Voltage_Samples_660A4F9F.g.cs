using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L3_Voltage_Samples_660A4F9F : PlcDocu.TcoIo.InputBase_8311D824
	{
		public U3_Samples_25492287 U3_Samples;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L3_Voltage_Samples_660A4F9F()
		{
		}
	}
#endif
}