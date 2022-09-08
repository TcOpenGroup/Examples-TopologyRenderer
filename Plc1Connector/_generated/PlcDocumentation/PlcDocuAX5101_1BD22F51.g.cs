using System;

namespace PlcDocu.Plc1
{
#if PLC_DOCU
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	public abstract class AX5101_1BD22F51 : PlcDocu.TcoIo.EtcSlaveBoxBase_77A0E4A7
	{
		public AT_x_4EC2E768 AT_x;
		public MDT_864618EC MDT;
		public TcoIo.WcState_9091E0EB WcState;
		public InfoData_F60A43AC InfoData;
		///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
		public AX5101_1BD22F51()
		{
		}
	}
#endif
}