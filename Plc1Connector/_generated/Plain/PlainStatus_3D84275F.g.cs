using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStatus_3D84275F : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _Transmit_accepted;
		public System.Boolean Transmit_accepted
		{
			get
			{
				return _Transmit_accepted;
			}

			set
			{
				if (_Transmit_accepted != value)
				{
					_Transmit_accepted = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Transmit_accepted)));
				}
			}
		}

		System.Boolean _Receive_request;
		public System.Boolean Receive_request
		{
			get
			{
				return _Receive_request;
			}

			set
			{
				if (_Receive_request != value)
				{
					_Receive_request = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Receive_request)));
				}
			}
		}

		System.Boolean _Init_accepted;
		public System.Boolean Init_accepted
		{
			get
			{
				return _Init_accepted;
			}

			set
			{
				if (_Init_accepted != value)
				{
					_Init_accepted = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Init_accepted)));
				}
			}
		}

		System.Boolean _Buffer_full;
		public System.Boolean Buffer_full
		{
			get
			{
				return _Buffer_full;
			}

			set
			{
				if (_Buffer_full != value)
				{
					_Buffer_full = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Buffer_full)));
				}
			}
		}

		System.Boolean _Parity_error;
		public System.Boolean Parity_error
		{
			get
			{
				return _Parity_error;
			}

			set
			{
				if (_Parity_error != value)
				{
					_Parity_error = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Parity_error)));
				}
			}
		}

		System.Boolean _Framing_error;
		public System.Boolean Framing_error
		{
			get
			{
				return _Framing_error;
			}

			set
			{
				if (_Framing_error != value)
				{
					_Framing_error = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Framing_error)));
				}
			}
		}

		System.Boolean _Overrun_error;
		public System.Boolean Overrun_error
		{
			get
			{
				return _Overrun_error;
			}

			set
			{
				if (_Overrun_error != value)
				{
					_Overrun_error = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Overrun_error)));
				}
			}
		}

		System.Byte _Input_length;
		public System.Byte Input_length
		{
			get
			{
				return _Input_length;
			}

			set
			{
				if (_Input_length != value)
				{
					_Input_length = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Input_length)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainStatus_3D84275F()
		{
		}
	}
}