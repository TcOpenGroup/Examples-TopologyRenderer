using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Current_Samples_B964735E : TcoIo.PlainInputBase_8311D824
	{
		PlainI3_Samples_25492287 _I3_Samples;
		public PlainI3_Samples_25492287 I3_Samples
		{
			get
			{
				return _I3_Samples;
			}

			set
			{
				if (_I3_Samples != value)
				{
					_I3_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I3_Samples)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL3_Current_Samples_B964735E()
		{
			_I3_Samples = new PlainI3_Samples_25492287();
		}
	}
}