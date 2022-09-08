using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class COM_TxPDO_Map_Inputs_Channel_3801C95E : PlcDocu.TcoIo.InputBase_8311D824
	{
		public Status_3D84275F Status;
		public object Data_In;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public COM_TxPDO_Map_Inputs_Channel_3801C95E()
		{
		}
	}
#endif
}