using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCtrl_1EFB4D3B : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _Transmit_request;
		public System.Boolean Transmit_request
		{
			get
			{
				return _Transmit_request;
			}

			set
			{
				if (_Transmit_request != value)
				{
					_Transmit_request = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Transmit_request)));
				}
			}
		}

		System.Boolean _Receive_accepted;
		public System.Boolean Receive_accepted
		{
			get
			{
				return _Receive_accepted;
			}

			set
			{
				if (_Receive_accepted != value)
				{
					_Receive_accepted = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Receive_accepted)));
				}
			}
		}

		System.Boolean _Init_request;
		public System.Boolean Init_request
		{
			get
			{
				return _Init_request;
			}

			set
			{
				if (_Init_request != value)
				{
					_Init_request = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Init_request)));
				}
			}
		}

		System.Boolean _Send_continuous;
		public System.Boolean Send_continuous
		{
			get
			{
				return _Send_continuous;
			}

			set
			{
				if (_Send_continuous != value)
				{
					_Send_continuous = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Send_continuous)));
				}
			}
		}

		System.Byte _Output_length;
		public System.Byte Output_length
		{
			get
			{
				return _Output_length;
			}

			set
			{
				if (_Output_length != value)
				{
					_Output_length = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_length)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainCtrl_1EFB4D3B()
		{
		}
	}
}