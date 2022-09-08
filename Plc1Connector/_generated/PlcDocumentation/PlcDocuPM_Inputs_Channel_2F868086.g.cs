using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class PM_Inputs_Channel_2F868086 : PlcDocu.TcoIo.InputBase_8311D824
	{
		public object TxPDO_Toggle;
		public object Current;
		public object Voltage;
		public object Active_power;
		public object Index;
		public object Variant_value;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public PM_Inputs_Channel_2F868086()
		{
		}
	}
#endif
}