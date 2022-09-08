using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MDT_864618EC : PlcDocu.TcoIo.OutputBase_10CEE7DE
	{
		public object Master_control_word;
		public object Position_command_value;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MDT_864618EC()
		{
		}
	}
#endif
}