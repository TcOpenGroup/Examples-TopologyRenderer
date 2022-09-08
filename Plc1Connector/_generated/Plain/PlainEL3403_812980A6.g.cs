using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3403_812980A6 : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainPM_Inputs_Channel_2F868086 _PM_Inputs_Channel_1;
		public PlainPM_Inputs_Channel_2F868086 PM_Inputs_Channel_1
		{
			get
			{
				return _PM_Inputs_Channel_1;
			}

			set
			{
				if (_PM_Inputs_Channel_1 != value)
				{
					_PM_Inputs_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Inputs_Channel_1)));
				}
			}
		}

		PlainPM_Inputs_Channel_2F868086 _PM_Inputs_Channel_2;
		public PlainPM_Inputs_Channel_2F868086 PM_Inputs_Channel_2
		{
			get
			{
				return _PM_Inputs_Channel_2;
			}

			set
			{
				if (_PM_Inputs_Channel_2 != value)
				{
					_PM_Inputs_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Inputs_Channel_2)));
				}
			}
		}

		PlainPM_Inputs_Channel_2F868086 _PM_Inputs_Channel_3;
		public PlainPM_Inputs_Channel_2F868086 PM_Inputs_Channel_3
		{
			get
			{
				return _PM_Inputs_Channel_3;
			}

			set
			{
				if (_PM_Inputs_Channel_3 != value)
				{
					_PM_Inputs_Channel_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Inputs_Channel_3)));
				}
			}
		}

		PlainPM_Status_data_2A9514CB _PM_Status_data;
		public PlainPM_Status_data_2A9514CB PM_Status_data
		{
			get
			{
				return _PM_Status_data;
			}

			set
			{
				if (_PM_Status_data != value)
				{
					_PM_Status_data = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Status_data)));
				}
			}
		}

		PlainPM_Outputs_Channel_E5FBDE30 _PM_Outputs_Channel_1;
		public PlainPM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_1
		{
			get
			{
				return _PM_Outputs_Channel_1;
			}

			set
			{
				if (_PM_Outputs_Channel_1 != value)
				{
					_PM_Outputs_Channel_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Outputs_Channel_1)));
				}
			}
		}

		PlainPM_Outputs_Channel_E5FBDE30 _PM_Outputs_Channel_2;
		public PlainPM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_2
		{
			get
			{
				return _PM_Outputs_Channel_2;
			}

			set
			{
				if (_PM_Outputs_Channel_2 != value)
				{
					_PM_Outputs_Channel_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Outputs_Channel_2)));
				}
			}
		}

		PlainPM_Outputs_Channel_E5FBDE30 _PM_Outputs_Channel_3;
		public PlainPM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_3
		{
			get
			{
				return _PM_Outputs_Channel_3;
			}

			set
			{
				if (_PM_Outputs_Channel_3 != value)
				{
					_PM_Outputs_Channel_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PM_Outputs_Channel_3)));
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

		TcoIo.PlainInfoData_23CBA837 _InfoData;
		public TcoIo.PlainInfoData_23CBA837 InfoData
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
		public PlainEL3403_812980A6()
		{
			_PM_Inputs_Channel_1 = new PlainPM_Inputs_Channel_2F868086();
			_PM_Inputs_Channel_2 = new PlainPM_Inputs_Channel_2F868086();
			_PM_Inputs_Channel_3 = new PlainPM_Inputs_Channel_2F868086();
			_PM_Status_data = new PlainPM_Status_data_2A9514CB();
			_PM_Outputs_Channel_1 = new PlainPM_Outputs_Channel_E5FBDE30();
			_PM_Outputs_Channel_2 = new PlainPM_Outputs_Channel_E5FBDE30();
			_PM_Outputs_Channel_3 = new PlainPM_Outputs_Channel_E5FBDE30();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new TcoIo.PlainInfoData_23CBA837();
		}
	}
}