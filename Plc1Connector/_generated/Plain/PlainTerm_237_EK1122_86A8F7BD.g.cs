using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_237_EK1122_86A8F7BD : Plc1.PlainEK1122_1FC0878B
	{
		PlainAX5101_1BD22F51 _Drive_238_AX5101_0000_0214;
		public PlainAX5101_1BD22F51 Drive_238_AX5101_0000_0214
		{
			get
			{
				return _Drive_238_AX5101_0000_0214;
			}

			set
			{
				if (_Drive_238_AX5101_0000_0214 != value)
				{
					_Drive_238_AX5101_0000_0214 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Drive_238_AX5101_0000_0214)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainTerm_237_EK1122_86A8F7BD()
		{
			_Drive_238_AX5101_0000_0214 = new PlainAX5101_1BD22F51();
		}
	}
}