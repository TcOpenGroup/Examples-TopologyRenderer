using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStartTimeNextLatch_02E0C1C8 : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.UInt32 _Low;
		public System.UInt32 Low
		{
			get
			{
				return _Low;
			}

			set
			{
				if (_Low != value)
				{
					_Low = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Low)));
				}
			}
		}

		System.UInt32 _Hi;
		public System.UInt32 Hi
		{
			get
			{
				return _Hi;
			}

			set
			{
				if (_Hi != value)
				{
					_Hi = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Hi)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainStartTimeNextLatch_02E0C1C8()
		{
		}
	}
}