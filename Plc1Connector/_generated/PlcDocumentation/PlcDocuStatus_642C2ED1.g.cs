using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Status_642C2ED1
	{
		public object Output_short_circuit;
		public object Output_buffer_overflow;
		public object Output_state;
		public object Input_cycle_counter;
		public object Output_order_feedback;
		public object Events_in_output_buffer;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Status_642C2ED1()
		{
		}
	}
#endif
}