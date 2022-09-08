using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Voltage_Samples_660A4F9F : TcoIo.PlainInputBase_8311D824
	{
		PlainU3_Samples_25492287 _U3_Samples;
		public PlainU3_Samples_25492287 U3_Samples
		{
			get
			{
				return _U3_Samples;
			}

			set
			{
				if (_U3_Samples != value)
				{
					_U3_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(U3_Samples)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL3_Voltage_Samples_660A4F9F()
		{
			_U3_Samples = new PlainU3_Samples_25492287();
		}
	}
}