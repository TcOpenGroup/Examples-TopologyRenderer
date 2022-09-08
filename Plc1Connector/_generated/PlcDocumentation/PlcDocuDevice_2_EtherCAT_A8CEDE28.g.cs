using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class Device_2_EtherCAT_A8CEDE28 : PlcDocu.TcoIo.EtcMasterBase_62654B43
	{
		public Term_9_EK1100_91BFEC25 Term_9_EK1100;
		public SyncUnits_91A42BBF SyncUnits;
		public TcoIo.Inputs_A65FACA4 Inputs;
		public TcoIo.Outputs_23C0ED1D Outputs;
		public TcoIo.InfoData_84133AC9 InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public Device_2_EtherCAT_A8CEDE28()
		{
		}
	}
#endif
}