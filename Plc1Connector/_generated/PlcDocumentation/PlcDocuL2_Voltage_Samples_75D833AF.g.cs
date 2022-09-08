using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L2_Voltage_Samples_75D833AF : PlcDocu.TcoIo.InputBase_8311D824
	{
		public U2_Samples_25492287 U2_Samples;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L2_Voltage_Samples_75D833AF()
		{
		}
	}
#endif
}