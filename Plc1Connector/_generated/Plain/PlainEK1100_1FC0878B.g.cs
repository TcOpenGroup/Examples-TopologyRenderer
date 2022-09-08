using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEK1100_1FC0878B : TcoIo.PlainEtcSlaveBoxBase_77A0E4A7
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
		public PlainEK1100_1FC0878B()
		{
			_InfoData = new TcoIo.PlainInfoData_6F19DB2B();
		}
	}
}