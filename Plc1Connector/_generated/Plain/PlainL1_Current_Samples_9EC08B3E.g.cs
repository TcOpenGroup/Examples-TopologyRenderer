using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Current_Samples_9EC08B3E : TcoIo.PlainInputBase_8311D824
	{
		PlainI1_Samples_25492287 _I1_Samples;
		public PlainI1_Samples_25492287 I1_Samples
		{
			get
			{
				return _I1_Samples;
			}

			set
			{
				if (_I1_Samples != value)
				{
					_I1_Samples = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(I1_Samples)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainL1_Current_Samples_9EC08B3E()
		{
			_I1_Samples = new PlainI1_Samples_25492287();
		}
	}
}