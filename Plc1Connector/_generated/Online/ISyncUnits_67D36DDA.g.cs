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
	public partial interface ISyncUnits_67D36DDA : Vortex.Connector.IVortexOnlineObject, TcoIo.ISyncUnitsBase_AD6C35CE
	{
		ISyncUnitTasks_4BE01469 _default
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

		new Plc1.PlainSyncUnits_67D36DDA CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainSyncUnits_67D36DDA source);
		void FlushOnlineToPlain(Plc1.PlainSyncUnits_67D36DDA source);
	}
}