using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL6001_0DE01E7E : TcoIo.PlainEtcSlaveTerminalBase_947E5A46
	{
		PlainCOM_Inputs_3801C95E _COM_Inputs;
		public PlainCOM_Inputs_3801C95E COM_Inputs
		{
			get
			{
				return _COM_Inputs;
			}

			set
			{
				if (_COM_Inputs != value)
				{
					_COM_Inputs = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(COM_Inputs)));
				}
			}
		}

		PlainCOM_Outputs_DEF408EC _COM_Outputs;
		public PlainCOM_Outputs_DEF408EC COM_Outputs
		{
			get
			{
				return _COM_Outputs;
			}

			set
			{
				if (_COM_Outputs != value)
				{
					_COM_Outputs = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(COM_Outputs)));
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
		public PlainEL6001_0DE01E7E()
		{
			_COM_Inputs = new PlainCOM_Inputs_3801C95E();
			_COM_Outputs = new PlainCOM_Outputs_DEF408EC();
			_WcState = new TcoIo.PlainWcState_9091E0EB();
			_InfoData = new TcoIo.PlainInfoData_23CBA837();
		}
	}
}