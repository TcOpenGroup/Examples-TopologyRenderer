using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class AI_Sample_Count_EA88CAD9 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public object Sample_Count;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public AI_Sample_Count_EA88CAD9()
		{
		}
	}
#endif
}