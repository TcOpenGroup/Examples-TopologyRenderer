using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class InfoData_F60A43AC : PlcDocu.TcoIo.InputBase_8311D824
	{
		public TcoIo.TcoAmsAddr AdsAddr;
		public object DcOutputShift;
		public object DcInputShift;
		public object Chn0;
		public object State;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public InfoData_F60A43AC()
		{
		}
	}
#endif
}