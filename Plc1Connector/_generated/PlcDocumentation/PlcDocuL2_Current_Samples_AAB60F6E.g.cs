using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L2_Current_Samples_AAB60F6E : PlcDocu.TcoIo.InputBase_8311D824
	{
		public I2_Samples_25492287 I2_Samples;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L2_Current_Samples_AAB60F6E()
		{
		}
	}
#endif
}