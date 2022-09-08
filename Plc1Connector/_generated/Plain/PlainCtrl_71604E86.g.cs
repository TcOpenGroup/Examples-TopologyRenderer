using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCtrl_71604E86 : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
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

		System.Boolean _Send_continues;
		public System.Boolean Send_continues
		{
			get
			{
				return _Send_continues;
			}

			set
			{
				if (_Send_continues != value)
				{
					_Send_continues = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Send_continues)));
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
		public PlainCtrl_71604E86()
		{
		}
	}
}