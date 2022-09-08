using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Current_Samples_AAB60F6E : TcoIo.PlainInputBase_8311D824
	{
		PlainI2_Samples_25492287 _I2_Samples;
		public PlainI2_Samples_25492287 I2_Samples
		{
			get
			{
				return _I2_Samples;
			}

			set
			{
				if (_I2_Samples != value)
				{
					_I2_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I2_Samples)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL2_Current_Samples_AAB60F6E()
		{
			_I2_Samples = new PlainI2_Samples_25492287();
		}
	}
}