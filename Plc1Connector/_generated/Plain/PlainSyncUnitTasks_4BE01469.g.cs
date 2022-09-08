using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSyncUnitTasks_4BE01469 : TcoIo.PlainSyncUnitTasksBase_7C8711EB
	{
		TcoIo.PlainSyncUnitTask_AB2F5079 _unreferenced;
		public TcoIo.PlainSyncUnitTask_AB2F5079 unreferenced
		{
			get
			{
				return _unreferenced;
			}

			set
			{
				if (_unreferenced != value)
				{
					_unreferenced = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(unreferenced)));
				}
			}
		}

		TcoIo.PlainSyncUnitTask_AB2F5079 _PlcTask;
		public TcoIo.PlainSyncUnitTask_AB2F5079 PlcTask
		{
			get
			{
				return _PlcTask;
			}

			set
			{
				if (_PlcTask != value)
				{
					_PlcTask = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PlcTask)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainSyncUnitTasks_4BE01469()
		{
			_unreferenced = new TcoIo.PlainSyncUnitTask_AB2F5079();
			_PlcTask = new TcoIo.PlainSyncUnitTask_AB2F5079();
		}
	}
}