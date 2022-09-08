using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAO_Output_Channel_BA7EBB7C : TcoIo.PlainOutputBase_10CEE7DE
	{
		System.Int16 _Analog_output;
		public System.Int16 Analog_output
		{
			get
			{
				return _Analog_output;
			}

			set
			{
				if (_Analog_output != value)
				{
					_Analog_output = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Analog_output)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainAO_Output_Channel_BA7EBB7C()
		{
		}
	}
}