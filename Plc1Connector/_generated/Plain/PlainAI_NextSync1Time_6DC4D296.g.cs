using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAI_NextSync1Time_6DC4D296 : TcoIo.PlainInputBase_8311D824
	{
		PlainStartTimeNextLatch_02E0C1C8 _StartTimeNextLatch;
		public PlainStartTimeNextLatch_02E0C1C8 StartTimeNextLatch
		{
			get
			{
				return _StartTimeNextLatch;
			}

			set
			{
				if (_StartTimeNextLatch != value)
				{
					_StartTimeNextLatch = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(StartTimeNextLatch)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainAI_NextSync1Time_6DC4D296()
		{
			_StartTimeNextLatch = new PlainStartTimeNextLatch_02E0C1C8();
		}
	}
}