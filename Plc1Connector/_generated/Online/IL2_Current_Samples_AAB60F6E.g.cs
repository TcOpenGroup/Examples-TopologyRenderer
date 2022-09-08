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
	public partial interface IL2_Current_Samples_AAB60F6E : Vortex.Connector.IVortexOnlineObject, TcoIo.IInputBase_8311D824
	{
		[IoLinkable("Inputs")]
		II2_Samples_25492287 I2_Samples
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

		new Plc1.PlainL2_Current_Samples_AAB60F6E CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainL2_Current_Samples_AAB60F6E source);
		void FlushOnlineToPlain(Plc1.PlainL2_Current_Samples_AAB60F6E source);
	}
}