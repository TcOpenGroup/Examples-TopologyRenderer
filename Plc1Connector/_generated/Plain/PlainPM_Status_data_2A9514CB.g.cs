using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPM_Status_data_2A9514CB : TcoIo.PlainInputBase_8311D824
	{
		System.Boolean _Missing_zero_crossing_A;
		public System.Boolean Missing_zero_crossing_A
		{
			get
			{
				return _Missing_zero_crossing_A;
			}

			set
			{
				if (_Missing_zero_crossing_A != value)
				{
					_Missing_zero_crossing_A = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Missing_zero_crossing_A)));
				}
			}
		}

		System.Boolean _Missing_zero_crossing_B;
		public System.Boolean Missing_zero_crossing_B
		{
			get
			{
				return _Missing_zero_crossing_B;
			}

			set
			{
				if (_Missing_zero_crossing_B != value)
				{
					_Missing_zero_crossing_B = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Missing_zero_crossing_B)));
				}
			}
		}

		System.Boolean _Missing_zero_crossing_C;
		public System.Boolean Missing_zero_crossing_C
		{
			get
			{
				return _Missing_zero_crossing_C;
			}

			set
			{
				if (_Missing_zero_crossing_C != value)
				{
					_Missing_zero_crossing_C = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Missing_zero_crossing_C)));
				}
			}
		}

		System.Boolean _Phase_sequence_error;
		public System.Boolean Phase_sequence_error
		{
			get
			{
				return _Phase_sequence_error;
			}

			set
			{
				if (_Phase_sequence_error != value)
				{
					_Phase_sequence_error = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Phase_sequence_error)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainPM_Status_data_2A9514CB()
		{
		}
	}
}