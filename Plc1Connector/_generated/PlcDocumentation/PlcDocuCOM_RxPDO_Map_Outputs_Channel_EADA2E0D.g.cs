using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class COM_RxPDO_Map_Outputs_Channel_EADA2E0D : PlcDocu.TcoIo.OutputBase_10CEE7DE
	{
		public Ctrl_1EFB4D3B Ctrl;
		public object Data_Out;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D()
		{
		}
	}
#endif
}