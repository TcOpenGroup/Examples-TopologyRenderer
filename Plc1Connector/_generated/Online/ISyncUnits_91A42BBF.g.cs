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
	public partial interface ISyncUnits_91A42BBF : Vortex.Connector.IVortexOnlineObject, TcoIo.ISyncUnitsBase_AD6C35CE
	{
		ISyncUnitTasks_4BE01469 _default
		{
			get;
		}

		ISyncUnitTasks_4BE01469 Row_0
		{
			get;
		}

		ISyncUnitTasks_4BE01469 Row_1
		{
			get;
		}

		ISyncUnitTasks_4BE01469 Row_2
		{
			get;
		}

		ISyncUnitTasks_4BE01469 Row_3
		{
			get;
		}

		ISyncUnitTasks_4BE01469 Row_4
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

		new Plc1.PlainSyncUnits_91A42BBF CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainSyncUnits_91A42BBF source);
		void FlushOnlineToPlain(Plc1.PlainSyncUnits_91A42BBF source);
	}
}