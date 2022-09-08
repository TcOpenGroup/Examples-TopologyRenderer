using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDevice_2_EtherCAT_A8CEDE28 : TcoIo.PlainEtcMasterBase_62654B43
	{
		PlainTerm_9_EK1100_91BFEC25 _Term_9_EK1100;
		public PlainTerm_9_EK1100_91BFEC25 Term_9_EK1100
		{
			get
			{
				return _Term_9_EK1100;
			}

			set
			{
				if (_Term_9_EK1100 != value)
				{
					_Term_9_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_9_EK1100)));
				}
			}
		}

		PlainSyncUnits_91A42BBF _SyncUnits;
		public PlainSyncUnits_91A42BBF SyncUnits
		{
			get
			{
				return _SyncUnits;
			}

			set
			{
				if (_SyncUnits != value)
				{
					_SyncUnits = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SyncUnits)));
				}
			}
		}

		TcoIo.PlainInputs_A65FACA4 _Inputs;
		public TcoIo.PlainInputs_A65FACA4 Inputs
		{
			get
			{
				return _Inputs;
			}

			set
			{
				if (_Inputs != value)
				{
					_Inputs = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Inputs)));
				}
			}
		}

		TcoIo.PlainOutputs_23C0ED1D _Outputs;
		public TcoIo.PlainOutputs_23C0ED1D Outputs
		{
			get
			{
				return _Outputs;
			}

			set
			{
				if (_Outputs != value)
				{
					_Outputs = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Outputs)));
				}
			}
		}

		TcoIo.PlainInfoData_84133AC9 _InfoData;
		public TcoIo.PlainInfoData_84133AC9 InfoData
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
		public PlainDevice_2_EtherCAT_A8CEDE28()
		{
			_Term_9_EK1100 = new PlainTerm_9_EK1100_91BFEC25();
			_SyncUnits = new PlainSyncUnits_91A42BBF();
			_Inputs = new TcoIo.PlainInputs_A65FACA4();
			_Outputs = new TcoIo.PlainOutputs_23C0ED1D();
			_InfoData = new TcoIo.PlainInfoData_84133AC9();
		}
	}
}