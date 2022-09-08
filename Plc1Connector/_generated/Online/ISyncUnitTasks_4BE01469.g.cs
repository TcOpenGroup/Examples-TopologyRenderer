using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ISyncUnitTasks_4BE01469 : Vortex.Connector.IVortexOnlineObject, TcoIo.ISyncUnitTasksBase_7C8711EB
	{
		TcoIo.ISyncUnitTask_AB2F5079 unreferenced
		{
			get;
		}

		TcoIo.ISyncUnitTask_AB2F5079 PlcTask
		{
			get;
		}

		System.String AttributeBoxType
		{
			get;
		}

		System.String AttributeId
		{
			get;
		}

		System.String AttributeCRC
		{
			get;
		}

		System.String AttributeSize
		{
			get;
		}

		new Plc1.PlainSyncUnitTasks_4BE01469 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainSyncUnitTasks_4BE01469 source);
		void FlushOnlineToPlain(Plc1.PlainSyncUnitTasks_4BE01469 source);
	}
}