using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class I3_Status_DC903920
	{
		public object Underrange;
		public object Overrange;
		public object Limit_x;
		public object Error;
		public object Sync_error;
		public object TxPDO_State;
		public object TxPDO_Toggle;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public I3_Status_DC903920()
		{
		}
	}
#endif
}