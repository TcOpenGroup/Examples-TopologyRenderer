using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class EL6001_0DE01E7E : PlcDocu.TcoIo.EtcSlaveTerminalBase_947E5A46
	{
		public COM_Inputs_3801C95E COM_Inputs;
		public COM_Outputs_DEF408EC COM_Outputs;
		public TcoIo.WcState_9091E0EB WcState;
		public TcoIo.InfoData_23CBA837 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public EL6001_0DE01E7E()
		{
		}
	}
#endif
}