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
	public partial interface IStartTimeNextLatch_02E0C1C8 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt Low
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt Hi
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

		System.String AttributeName
		{
			get;
		}

		Plc1.PlainStartTimeNextLatch_02E0C1C8 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainStartTimeNextLatch_02E0C1C8 source);
		void FlushOnlineToPlain(Plc1.PlainStartTimeNextLatch_02E0C1C8 source);
	}
}