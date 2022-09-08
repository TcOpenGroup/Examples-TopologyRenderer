using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Voltage_Samples_75D833AF : TcoIo.PlainInputBase_8311D824
	{
		PlainU2_Samples_25492287 _U2_Samples;
		public PlainU2_Samples_25492287 U2_Samples
		{
			get
			{
				return _U2_Samples;
			}

			set
			{
				if (_U2_Samples != value)
				{
					_U2_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(U2_Samples)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL2_Voltage_Samples_75D833AF()
		{
			_U2_Samples = new PlainU2_Samples_25492287();
		}
	}
}