using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPM_Outputs_Channel_E5FBDE30 : TcoIo.PlainOutputBase_10CEE7DE
	{
		System.Byte _Index;
		public System.Byte Index
		{
			get
			{
				return _Index;
			}

			set
			{
				if (_Index != value)
				{
					_Index = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Index)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainPM_Outputs_Channel_E5FBDE30()
		{
		}
	}
}