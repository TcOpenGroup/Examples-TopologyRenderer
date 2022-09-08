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
	public partial interface IEK1200_013D0B49 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveBoxBase_77A0E4A7
	{
		System.String AttributeVendorId
		{
			get;
		}

		System.String AttributeBoxType
		{
			get;
		}

		System.String AttributeDescription
		{
			get;
		}

		System.String AttributePhysics
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

		new Plc1.PlainEK1200_013D0B49 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEK1200_013D0B49 source);
		void FlushOnlineToPlain(Plc1.PlainEK1200_013D0B49 source);
	}
}