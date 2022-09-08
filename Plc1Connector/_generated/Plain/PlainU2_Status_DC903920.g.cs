using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainU2_Status_DC903920 : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _Underrange;
		public System.Boolean Underrange
		{
			get
			{
				return _Underrange;
			}

			set
			{
				if (_Underrange != value)
				{
					_Underrange = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Underrange)));
				}
			}
		}

		System.Boolean _Overrange;
		public System.Boolean Overrange
		{
			get
			{
				return _Overrange;
			}

			set
			{
				if (_Overrange != value)
				{
					_Overrange = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Overrange)));
				}
			}
		}

		System.Byte _Limit_x;
		public System.Byte Limit_x
		{
			get
			{
				return _Limit_x;
			}

			set
			{
				if (_Limit_x != value)
				{
					_Limit_x = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Limit_x)));
				}
			}
		}

		System.Boolean _Error;
		public System.Boolean Error
		{
			get
			{
				return _Error;
			}

			set
			{
				if (_Error != value)
				{
					_Error = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Error)));
				}
			}
		}

		System.Boolean _Sync_error;
		public System.Boolean Sync_error
		{
			get
			{
				return _Sync_error;
			}

			set
			{
				if (_Sync_error != value)
				{
					_Sync_error = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Sync_error)));
				}
			}
		}

		System.Boolean _TxPDO_State;
		public System.Boolean TxPDO_State
		{
			get
			{
				return _TxPDO_State;
			}

			set
			{
				if (_TxPDO_State != value)
				{
					_TxPDO_State = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TxPDO_State)));
				}
			}
		}

		System.Boolean _TxPDO_Toggle;
		public System.Boolean TxPDO_Toggle
		{
			get
			{
				return _TxPDO_Toggle;
			}

			set
			{
				if (_TxPDO_Toggle != value)
				{
					_TxPDO_Toggle = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TxPDO_Toggle)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainU2_Status_DC903920()
		{
		}
	}
}