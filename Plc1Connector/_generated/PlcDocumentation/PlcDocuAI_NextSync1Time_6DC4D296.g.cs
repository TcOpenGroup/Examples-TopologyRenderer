using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class AI_NextSync1Time_6DC4D296 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public StartTimeNextLatch_02E0C1C8 StartTimeNextLatch;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public AI_NextSync1Time_6DC4D296()
		{
		}
	}
#endif
}