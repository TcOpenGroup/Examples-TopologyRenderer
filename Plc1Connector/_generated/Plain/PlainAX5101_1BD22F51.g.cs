using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAX5101_1BD22F51 : TcoIo.PlainEtcSlaveBoxBase_77A0E4A7
	{
		PlainAT_x_4EC2E768 _AT_x;
		public PlainAT_x_4EC2E768 AT_x
		{
			get
			{
				return _AT_x;
			}

			set
			{
				if (_AT_x != value)
				{
					_AT_x = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AT_x)));
				}
			}
		}

		PlainMDT_864618EC _MDT;
		public PlainMDT_864618EC MDT
		{
			get
			{
				return _MDT;
			}

			set
			{
				if (_MDT != value)
				{
					_MDT = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MDT)));
				}
			}
		}

		TcoIo.PlainWcState_9091E0EB _WcState;
		public TcoIo.PlainWcState_9091E0EB WcState
		{
			get
			{
				return _WcState;
			}

			set
			{
				if (_WcState != value)
				{
					_WcState = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WcState)));
				}
			}
		}

		PlainInfoData_F60A43AC _InfoData;
		public PlainInfoData_F60A43AC InfoData
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
		public PlainAX5101_1BD22F51()
		{
			_AT_x = new PlainAT_x_4EC2E768();
			_MDT = new PlainMDT_864618EC();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new PlainInfoData_F60A43AC();
		}
	}
}