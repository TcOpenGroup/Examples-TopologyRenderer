using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSyncUnits_67D36DDA : TcoIo.PlainSyncUnitsBase_AD6C35CE
	{
		PlainSyncUnitTasks_4BE01469 __default;
		public PlainSyncUnitTasks_4BE01469 _default
		{
			get
			{
				return __default;
			}

			set
			{
				if (__default != value)
				{
					__default = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_default)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainSyncUnits_67D36DDA()
		{
			__default = new PlainSyncUnitTasks_4BE01469();
		}
	}
}