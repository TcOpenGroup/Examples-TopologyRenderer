using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L1_Current_Samples_9EC08B3E : PlcDocu.TcoIo.InputBase_8311D824
	{
		public I1_Samples_25492287 I1_Samples;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L1_Current_Samples_9EC08B3E()
		{
		}
	}
#endif
}