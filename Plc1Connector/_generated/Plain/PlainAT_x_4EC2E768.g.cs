using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAT_x_4EC2E768 : TcoIo.PlainInputBase_8311D824
	{
		System.UInt16 _Drive_status_word;
		public System.UInt16 Drive_status_word
		{
			get
			{
				return _Drive_status_word;
			}

			set
			{
				if (_Drive_status_word != value)
				{
					_Drive_status_word = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Drive_status_word)));
				}
			}
		}

		System.Int32 _Position_feedback_1_value;
		public System.Int32 Position_feedback_1_value
		{
			get
			{
				return _Position_feedback_1_value;
			}

			set
			{
				if (_Position_feedback_1_value != value)
				{
					_Position_feedback_1_value = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Position_feedback_1_value)));
				}
			}
		}

		System.Int32 _Following_distance;
		public System.Int32 Following_distance
		{
			get
			{
				return _Following_distance;
			}

			set
			{
				if (_Following_distance != value)
				{
					_Following_distance = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Following_distance)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainAT_x_4EC2E768()
		{
		}
	}
}