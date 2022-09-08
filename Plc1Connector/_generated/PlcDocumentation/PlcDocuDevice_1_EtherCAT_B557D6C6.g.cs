using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Device_1_EtherCAT_B557D6C6 : PlcDocu.TcoIo.EtcMasterBase_62654B43
	{
		public Term_1_EK1200_B38DC9A8 Term_1_EK1200;
		public SyncUnits_67D36DDA SyncUnits;
		public TcoIo.Inputs_A65FACA4 Inputs;
		public TcoIo.Outputs_23C0ED1D Outputs;
		public TcoIo.InfoData_84133AC9 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Device_1_EtherCAT_B557D6C6()
		{
		}
	}
#endif
}