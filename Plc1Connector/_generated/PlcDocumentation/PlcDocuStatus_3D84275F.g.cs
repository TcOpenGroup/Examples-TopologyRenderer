using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Status_3D84275F
	{
		public object Transmit_accepted;
		public object Receive_request;
		public object Init_accepted;
		public object Buffer_full;
		public object Parity_error;
		public object Framing_error;
		public object Overrun_error;
		public object Input_length;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Status_3D84275F()
		{
		}
	}
#endif
}