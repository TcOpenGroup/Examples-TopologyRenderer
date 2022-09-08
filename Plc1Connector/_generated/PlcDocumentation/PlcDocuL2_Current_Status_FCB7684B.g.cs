using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class L2_Current_Status_FCB7684B : PlcDocu.TcoIo.InputBase_8311D824
	{
		public I2_Status_DC903920 I2_Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public L2_Current_Status_FCB7684B()
		{
		}
	}
#endif
}