using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowSyncUnitTasks_4BE01469 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowSyncUnitTasksBase_7C8711EB
	{
		TcoIo.IShadowSyncUnitTask_AB2F5079 unreferenced
		{
			get;
		}

		TcoIo.IShadowSyncUnitTask_AB2F5079 PlcTask
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
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainSyncUnitTasks_4BE01469 source);
	}
}