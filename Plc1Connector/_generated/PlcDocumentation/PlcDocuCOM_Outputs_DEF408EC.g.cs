using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class COM_Outputs_DEF408EC : PlcDocu.TcoIo.OutputBase_10CEE7DE
	{
		public Ctrl_71604E86 Ctrl;
		public object Data_Out;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public COM_Outputs_DEF408EC()
		{
		}
	}
#endif
}