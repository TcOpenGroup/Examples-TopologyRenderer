using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMDT_864618EC : TcoIo.PlainOutputBase_10CEE7DE
	{
		System.UInt16 _Master_control_word;
		public System.UInt16 Master_control_word
		{
			get
			{
				return _Master_control_word;
			}

			set
			{
				if (_Master_control_word != value)
				{
					_Master_control_word = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Master_control_word)));
				}
			}
		}

		System.Int32 _Position_command_value;
		public System.Int32 Position_command_value
		{
			get
			{
				return _Position_command_value;
			}

			set
			{
				if (_Position_command_value != value)
				{
					_Position_command_value = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Position_command_value)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainMDT_864618EC()
		{
		}
	}
}