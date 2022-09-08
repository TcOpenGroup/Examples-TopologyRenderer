using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEK1122_1FC0878B : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		TcoIo.PlainInfoData_6F19DB2B _InfoData;
		public TcoIo.PlainInfoData_6F19DB2B InfoData
		{
			get
			{
				return _InfoData;
			}

			set
			{
				if (_InfoData != value)
				{
					_InfoData = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(InfoData)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainEK1122_1FC0878B()
		{
			_InfoData = new TcoIo.PlainInfoData_6F19DB2B();
		}
	}
}