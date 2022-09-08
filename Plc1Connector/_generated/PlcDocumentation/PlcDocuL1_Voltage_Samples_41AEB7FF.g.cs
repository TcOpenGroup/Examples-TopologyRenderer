using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L1_Voltage_Samples_41AEB7FF : PlcDocu.TcoIo.InputBase_8311D824
	{
		public U1_Samples_25492287 U1_Samples;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L1_Voltage_Samples_41AEB7FF()
		{
		}
	}
#endif
}