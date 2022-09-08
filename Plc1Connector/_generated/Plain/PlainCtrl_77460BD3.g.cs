using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCtrl_77460BD3 : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _Output_buffer_reset;
		public System.Boolean Output_buffer_reset
		{
			get
			{
				return _Output_buffer_reset;
			}

			set
			{
				if (_Output_buffer_reset != value)
				{
					_Output_buffer_reset = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_buffer_reset)));
				}
			}
		}

		System.Boolean _Manual_output_state;
		public System.Boolean Manual_output_state
		{
			get
			{
				return _Manual_output_state;
			}

			set
			{
				if (_Manual_output_state != value)
				{
					_Manual_output_state = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Manual_output_state)));
				}
			}
		}

		System.Boolean _Force_order;
		public System.Boolean Force_order
		{
			get
			{
				return _Force_order;
			}

			set
			{
				if (_Force_order != value)
				{
					_Force_order = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Force_order)));
				}
			}
		}

		System.Boolean _Enable_manual_operation;
		public System.Boolean Enable_manual_operation
		{
			get
			{
				return _Enable_manual_operation;
			}

			set
			{
				if (_Enable_manual_operation != value)
				{
					_Enable_manual_operation = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Enable_manual_operation)));
				}
			}
		}

		System.Byte _Output_order_counter;
		public System.Byte Output_order_counter
		{
			get
			{
				return _Output_order_counter;
			}

			set
			{
				if (_Output_order_counter != value)
				{
					_Output_order_counter = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Output_order_counter)));
				}
			}
		}

		System.Byte _No_of_output_events;
		public System.Byte No_of_output_events
		{
			get
			{
				return _No_of_output_events;
			}

			set
			{
				if (_No_of_output_events != value)
				{
					_No_of_output_events = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(No_of_output_events)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainCtrl_77460BD3()
		{
		}
	}
}