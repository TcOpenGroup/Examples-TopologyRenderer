using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class MTO_Inputs_Channel_53C09E8B : PlcDocu.TcoIo.InputBase_8311D824
	{
		public Status_642C2ED1 Status;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public MTO_Inputs_Channel_53C09E8B()
		{
		}
	}
#endif
}