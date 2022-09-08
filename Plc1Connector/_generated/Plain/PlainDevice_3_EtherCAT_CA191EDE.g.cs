using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDevice_3_EtherCAT_CA191EDE : TcoIo.PlainEtcMasterBase_62654B43
	{
		PlainTerm_146_EK1100_439F5464 _Term_146_EK1100;
		public PlainTerm_146_EK1100_439F5464 Term_146_EK1100
		{
			get
			{
				return _Term_146_EK1100;
			}

			set
			{
				if (_Term_146_EK1100 != value)
				{
					_Term_146_EK1100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Term_146_EK1100)));
				}
			}
		}

		PlainSyncUnits_67D36DDA _SyncUnits;
		public PlainSyncUnits_67D36DDA SyncUnits
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
		public PlainDevice_3_EtherCAT_CA191EDE()
		{
			_Term_146_EK1100 = new PlainTerm_146_EK1100_439F5464();
			_SyncUnits = new PlainSyncUnits_67D36DDA();
			_Inputs = new TcoIo.PlainInputs_A65FACA4();
			_Outputs = new TcoIo.PlainOutputs_23C0ED1D();
			_InfoData = new TcoIo.PlainInfoData_84133AC9();
		}
	}
}