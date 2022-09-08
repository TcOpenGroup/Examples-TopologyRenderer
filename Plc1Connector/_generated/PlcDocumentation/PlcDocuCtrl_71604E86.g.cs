using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Ctrl_71604E86
	{
		public object Transmit_request;
		public object Receive_accepted;
		public object Init_request;
		public object Send_continues;
		public object Output_length;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Ctrl_71604E86()
		{
		}
	}
#endif
}