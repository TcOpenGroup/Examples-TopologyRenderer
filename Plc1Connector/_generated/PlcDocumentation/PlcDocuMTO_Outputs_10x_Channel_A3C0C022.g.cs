using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MTO_Outputs_10x_Channel_A3C0C022 : PlcDocu.TcoIo.OutputBase_10CEE7DE
	{
		public Ctrl_77460BD3 Ctrl;
		public Outputs_A910484D Outputs;
		public object Output_event_time;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MTO_Outputs_10x_Channel_A3C0C022()
		{
		}
	}
#endif
}