using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Status_F2CE6D91
	{
		public object Underrange;
		public object Overrange;
		public object Limit_1;
		public object Limit_2;
		public object Error;
		public object TxPDO_State;
		public object TxPDO_Toggle;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Status_F2CE6D91()
		{
		}
	}
#endif
}