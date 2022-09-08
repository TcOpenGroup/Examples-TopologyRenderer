using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainGVL_iXlinker : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainDevice_1_EtherCAT_B557D6C6 _Device_1_EtherCAT;
		public PlainDevice_1_EtherCAT_B557D6C6 Device_1_EtherCAT
		{
			get
			{
				return _Device_1_EtherCAT;
			}

			set
			{
				if (_Device_1_EtherCAT != value)
				{
					_Device_1_EtherCAT = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Device_1_EtherCAT)));
				}
			}
		}

		PlainDevice_2_EtherCAT_A8CEDE28 _Device_2_EtherCAT;
		public PlainDevice_2_EtherCAT_A8CEDE28 Device_2_EtherCAT
		{
			get
			{
				return _Device_2_EtherCAT;
			}

			set
			{
				if (_Device_2_EtherCAT != value)
				{
					_Device_2_EtherCAT = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Device_2_EtherCAT)));
				}
			}
		}

		PlainDevice_3_EtherCAT_CA191EDE _Device_3_EtherCAT;
		public PlainDevice_3_EtherCAT_CA191EDE Device_3_EtherCAT
		{
			get
			{
				return _Device_3_EtherCAT;
			}

			set
			{
				if (_Device_3_EtherCAT != value)
				{
					_Device_3_EtherCAT = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Device_3_EtherCAT)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainGVL_iXlinker()
		{
			_Device_1_EtherCAT = new PlainDevice_1_EtherCAT_B557D6C6();
			_Device_2_EtherCAT = new PlainDevice_2_EtherCAT_A8CEDE28();
			_Device_3_EtherCAT = new PlainDevice_3_EtherCAT_CA191EDE();
		}
	}
}