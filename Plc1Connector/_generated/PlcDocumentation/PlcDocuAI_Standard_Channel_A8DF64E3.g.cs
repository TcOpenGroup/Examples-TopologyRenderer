using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class AI_Standard_Channel_A8DF64E3 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public Status_B0753356 Status;
		public object Value;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public AI_Standard_Channel_A8DF64E3()
		{
		}
	}
#endif
}