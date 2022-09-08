using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Device_3_EtherCAT_CA191EDE : PlcDocu.TcoIo.EtcMasterBase_62654B43
	{
		public Term_146_EK1100_439F5464 Term_146_EK1100;
		public SyncUnits_67D36DDA SyncUnits;
		public TcoIo.Inputs_A65FACA4 Inputs;
		public TcoIo.Outputs_23C0ED1D Outputs;
		public TcoIo.InfoData_84133AC9 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Device_3_EtherCAT_CA191EDE()
		{
		}
	}
#endif
}