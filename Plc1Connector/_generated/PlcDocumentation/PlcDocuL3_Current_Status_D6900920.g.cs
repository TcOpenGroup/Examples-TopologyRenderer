using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L3_Current_Status_D6900920 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public I3_Status_DC903920 I3_Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L3_Current_Status_D6900920()
		{
		}
	}
#endif
}