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
	public partial interface IL1_Current_Status_82DECBF6 : Vortex.Connector.IVortexOnlineObject, TcoIo.IInputBase_8311D824
	{
		[IoLinkable("Inputs")]
		II1_Status_DC903920 I1_Status
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

		new Plc1.PlainL1_Current_Status_82DECBF6 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainL1_Current_Status_82DECBF6 source);
		void FlushOnlineToPlain(Plc1.PlainL1_Current_Status_82DECBF6 source);
	}
}