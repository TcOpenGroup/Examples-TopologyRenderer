using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPM_Inputs_Channel_2F868086 : TcoIo.PlainInputBase_8311D824
	{
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

		System.Int32 _Current;
		public System.Int32 Current
		{
			get
			{
				return _Current;
			}

			set
			{
				if (_Current != value)
				{
					_Current = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Current)));
				}
			}
		}

		System.Int32 _Voltage;
		public System.Int32 Voltage
		{
			get
			{
				return _Voltage;
			}

			set
			{
				if (_Voltage != value)
				{
					_Voltage = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Voltage)));
				}
			}
		}

		System.Int32 _Active_power;
		public System.Int32 Active_power
		{
			get
			{
				return _Active_power;
			}

			set
			{
				if (_Active_power != value)
				{
					_Active_power = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Active_power)));
				}
			}
		}

		System.Byte _Index;
		public System.Byte Index
		{
			get
			{
				return _Index;
			}

			set
			{
				if (_Index != value)
				{
					_Index = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Index)));
				}
			}
		}

		System.Int32 _Variant_value;
		public System.Int32 Variant_value
		{
			get
			{
				return _Variant_value;
			}

			set
			{
				if (_Variant_value != value)
				{
					_Variant_value = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Variant_value)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainPM_Inputs_Channel_2F868086()
		{
		}
	}
}