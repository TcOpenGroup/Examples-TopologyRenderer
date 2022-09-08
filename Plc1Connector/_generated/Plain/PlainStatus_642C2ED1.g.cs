using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStatus_642C2ED1 : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _Output_short_circuit;
		public System.Boolean Output_short_circuit
		{
			get
			{
				return _Output_short_circuit;
			}

			set
			{
				if (_Output_short_circuit != value)
				{
					_Output_short_circuit = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_short_circuit)));
				}
			}
		}

		System.Boolean _Output_buffer_overflow;
		public System.Boolean Output_buffer_overflow
		{
			get
			{
				return _Output_buffer_overflow;
			}

			set
			{
				if (_Output_buffer_overflow != value)
				{
					_Output_buffer_overflow = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_buffer_overflow)));
				}
			}
		}

		System.Boolean _Output_state;
		public System.Boolean Output_state
		{
			get
			{
				return _Output_state;
			}

			set
			{
				if (_Output_state != value)
				{
					_Output_state = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_state)));
				}
			}
		}

		System.Byte _Input_cycle_counter;
		public System.Byte Input_cycle_counter
		{
			get
			{
				return _Input_cycle_counter;
			}

			set
			{
				if (_Input_cycle_counter != value)
				{
					_Input_cycle_counter = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Input_cycle_counter)));
				}
			}
		}

		System.Byte _Output_order_feedback;
		public System.Byte Output_order_feedback
		{
			get
			{
				return _Output_order_feedback;
			}

			set
			{
				if (_Output_order_feedback != value)
				{
					_Output_order_feedback = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_order_feedback)));
				}
			}
		}

		System.Byte _Events_in_output_buffer;
		public System.Byte Events_in_output_buffer
		{
			get
			{
				return _Events_in_output_buffer;
			}

			set
			{
				if (_Events_in_output_buffer != value)
				{
					_Events_in_output_buffer = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Events_in_output_buffer)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainStatus_642C2ED1()
		{
		}
	}
}