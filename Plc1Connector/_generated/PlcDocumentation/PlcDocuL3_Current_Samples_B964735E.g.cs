using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L3_Current_Samples_B964735E : PlcDocu.TcoIo.InputBase_8311D824
	{
		public I3_Samples_25492287 I3_Samples;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L3_Current_Samples_B964735E()
		{
		}
	}
#endif
}