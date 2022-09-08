using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSyncUnits_91A42BBF : TcoIo.PlainSyncUnitsBase_AD6C35CE
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

		PlainSyncUnitTasks_4BE01469 _Row_0;
		public PlainSyncUnitTasks_4BE01469 Row_0
		{
			get
			{
				return _Row_0;
			}

			set
			{
				if (_Row_0 != value)
				{
					_Row_0 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Row_0)));
				}
			}
		}

		PlainSyncUnitTasks_4BE01469 _Row_1;
		public PlainSyncUnitTasks_4BE01469 Row_1
		{
			get
			{
				return _Row_1;
			}

			set
			{
				if (_Row_1 != value)
				{
					_Row_1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Row_1)));
				}
			}
		}

		PlainSyncUnitTasks_4BE01469 _Row_2;
		public PlainSyncUnitTasks_4BE01469 Row_2
		{
			get
			{
				return _Row_2;
			}

			set
			{
				if (_Row_2 != value)
				{
					_Row_2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Row_2)));
				}
			}
		}

		PlainSyncUnitTasks_4BE01469 _Row_3;
		public PlainSyncUnitTasks_4BE01469 Row_3
		{
			get
			{
				return _Row_3;
			}

			set
			{
				if (_Row_3 != value)
				{
					_Row_3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Row_3)));
				}
			}
		}

		PlainSyncUnitTasks_4BE01469 _Row_4;
		public PlainSyncUnitTasks_4BE01469 Row_4
		{
			get
			{
				return _Row_4;
			}

			set
			{
				if (_Row_4 != value)
				{
					_Row_4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Row_4)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainSyncUnits_91A42BBF()
		{
			__default = new PlainSyncUnitTasks_4BE01469();
			_Row_0 = new PlainSyncUnitTasks_4BE01469();
			_Row_1 = new PlainSyncUnitTasks_4BE01469();
			_Row_2 = new PlainSyncUnitTasks_4BE01469();
			_Row_3 = new PlainSyncUnitTasks_4BE01469();
			_Row_4 = new PlainSyncUnitTasks_4BE01469();
		}
	}
}