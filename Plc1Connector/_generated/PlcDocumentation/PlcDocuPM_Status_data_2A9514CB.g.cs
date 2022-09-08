using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class PM_Status_data_2A9514CB : PlcDocu.TcoIo.InputBase_8311D824
	{
		public object Missing_zero_crossing_A;
		public object Missing_zero_crossing_B;
		public object Missing_zero_crossing_C;
		public object Phase_sequence_error;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public PM_Status_data_2A9514CB()
		{
		}
	}
#endif
}