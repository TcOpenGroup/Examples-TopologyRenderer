using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAI_Sample_Count_EA88CAD9 : TcoIo.PlainInputBase_8311D824
	{
		System.UInt16 _Sample_Count;
		public System.UInt16 Sample_Count
		{
			get
			{
				return _Sample_Count;
			}

			set
			{
				if (_Sample_Count != value)
				{
					_Sample_Count = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Sample_Count)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainAI_Sample_Count_EA88CAD9()
		{
		}
	}
}