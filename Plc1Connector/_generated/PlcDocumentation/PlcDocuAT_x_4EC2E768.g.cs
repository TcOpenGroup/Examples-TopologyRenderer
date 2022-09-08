using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class AT_x_4EC2E768 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public object Drive_status_word;
		public object Position_feedback_1_value;
		public object Following_distance;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public AT_x_4EC2E768()
		{
		}
	}
#endif
}