using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAI_Standard_Channel_A8DF64E3 : TcoIo.PlainInputBase_8311D824
	{
		PlainStatus_B0753356 _Status;
		public PlainStatus_B0753356 Status
		{
			get
			{
				return _Status;
			}

			set
			{
				if (_Status != value)
				{
					_Status = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Status)));
				}
			}
		}

		System.Int16 _Value;
		public System.Int16 Value
		{
			get
			{
				return _Value;
			}

			set
			{
				if (_Value != value)
				{
					_Value = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Value)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainAI_Standard_Channel_A8DF64E3()
		{
			_Status = new PlainStatus_B0753356();
		}
	}
}