using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL1008_78E8D3DD : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainChannel_830843C1 _Channel_1;
		public PlainChannel_830843C1 Channel_1
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

		PlainChannel_830843C1 _Channel_2;
		public PlainChannel_830843C1 Channel_2
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

		PlainChannel_830843C1 _Channel_3;
		public PlainChannel_830843C1 Channel_3
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

		PlainChannel_830843C1 _Channel_4;
		public PlainChannel_830843C1 Channel_4
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

		PlainChannel_830843C1 _Channel_5;
		public PlainChannel_830843C1 Channel_5
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

		PlainChannel_830843C1 _Channel_6;
		public PlainChannel_830843C1 Channel_6
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

		PlainChannel_830843C1 _Channel_7;
		public PlainChannel_830843C1 Channel_7
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

		PlainChannel_830843C1 _Channel_8;
		public PlainChannel_830843C1 Channel_8
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
		public PlainEL1008_78E8D3DD()
		{
			_Channel_1 = new PlainChannel_830843C1();
			_Channel_2 = new PlainChannel_830843C1();
			_Channel_3 = new PlainChannel_830843C1();
			_Channel_4 = new PlainChannel_830843C1();
			_Channel_5 = new PlainChannel_830843C1();
			_Channel_6 = new PlainChannel_830843C1();
			_Channel_7 = new PlainChannel_830843C1();
			_Channel_8 = new PlainChannel_830843C1();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new TcoIo.PlainInfoData_6F19DB2B();
		}
	}
}