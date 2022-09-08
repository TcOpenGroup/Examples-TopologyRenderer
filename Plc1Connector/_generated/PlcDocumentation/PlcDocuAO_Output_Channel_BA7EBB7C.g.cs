using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class AO_Output_Channel_BA7EBB7C : PlcDocu.TcoIo.OutputBase_10CEE7DE
	{
		public object Analog_output;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public AO_Output_Channel_BA7EBB7C()
		{
		}
	}
#endif
}