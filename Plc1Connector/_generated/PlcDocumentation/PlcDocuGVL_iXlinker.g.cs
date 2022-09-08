using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class GVL_iXlinker
	{
		public Device_1_EtherCAT_B557D6C6 Device_1_EtherCAT;
		public Device_2_EtherCAT_A8CEDE28 Device_2_EtherCAT;
		public Device_3_EtherCAT_CA191EDE Device_3_EtherCAT;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public GVL_iXlinker()
		{
		}
	}
#endif
}