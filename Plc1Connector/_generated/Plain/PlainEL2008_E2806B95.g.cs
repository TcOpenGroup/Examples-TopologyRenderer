using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL2008_E2806B95 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainChannel_42CA91F7 _Channel_1;
		public PlainChannel_42CA91F7 Channel_1
		{
			get
			{
				return _Channel_1;
			}

			set
			{
				if (_Channel_1 != value)
				{
					_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_1)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_2;
		public PlainChannel_42CA91F7 Channel_2
		{
			get
			{
				return _Channel_2;
			}

			set
			{
				if (_Channel_2 != value)
				{
					_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_2)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_3;
		public PlainChannel_42CA91F7 Channel_3
		{
			get
			{
				return _Channel_3;
			}

			set
			{
				if (_Channel_3 != value)
				{
					_Channel_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_3)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_4;
		public PlainChannel_42CA91F7 Channel_4
		{
			get
			{
				return _Channel_4;
			}

			set
			{
				if (_Channel_4 != value)
				{
					_Channel_4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_4)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_5;
		public PlainChannel_42CA91F7 Channel_5
		{
			get
			{
				return _Channel_5;
			}

			set
			{
				if (_Channel_5 != value)
				{
					_Channel_5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_5)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_6;
		public PlainChannel_42CA91F7 Channel_6
		{
			get
			{
				return _Channel_6;
			}

			set
			{
				if (_Channel_6 != value)
				{
					_Channel_6 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_6)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_7;
		public PlainChannel_42CA91F7 Channel_7
		{
			get
			{
				return _Channel_7;
			}

			set
			{
				if (_Channel_7 != value)
				{
					_Channel_7 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_7)));
				}
			}
		}

		PlainChannel_42CA91F7 _Channel_8;
		public PlainChannel_42CA91F7 Channel_8
		{
			get
			{
				return _Channel_8;
			}

			set
			{
				if (_Channel_8 != value)
				{
					_Channel_8 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Channel_8)));
				}
			}
		}

		TcoIo.PlainWcState_0B2B16F9 _WcState;
		public TcoIo.PlainWcState_0B2B16F9 WcState
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
		public PlainEL2008_E2806B95()
		{
			_Channel_1 = new PlainChannel_42CA91F7();
			_Channel_2 = new PlainChannel_42CA91F7();
			_Channel_3 = new PlainChannel_42CA91F7();
			_Channel_4 = new PlainChannel_42CA91F7();
			_Channel_5 = new PlainChannel_42CA91F7();
			_Channel_6 = new PlainChannel_42CA91F7();
			_Channel_7 = new PlainChannel_42CA91F7();
			_Channel_8 = new PlainChannel_42CA91F7();
			_WcState = new TcoIo.PlainWcState_0B2B16F9();
			_InfoData = new TcoIo.PlainInfoData_6F19DB2B();
		}
	}
}