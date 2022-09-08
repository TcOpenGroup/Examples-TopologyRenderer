using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L1_Current_Status_82DECBF6 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public I1_Status_DC903920 I1_Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L1_Current_Status_82DECBF6()
		{
		}
	}
#endif
}