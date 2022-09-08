using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Voltage_Samples_41AEB7FF : TcoIo.PlainInputBase_8311D824
	{
		PlainU1_Samples_25492287 _U1_Samples;
		public PlainU1_Samples_25492287 U1_Samples
		{
			get
			{
				return _U1_Samples;
			}

			set
			{
				if (_U1_Samples != value)
				{
					_U1_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(U1_Samples)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL1_Voltage_Samples_41AEB7FF()
		{
			_U1_Samples = new PlainU1_Samples_25492287();
		}
	}
}