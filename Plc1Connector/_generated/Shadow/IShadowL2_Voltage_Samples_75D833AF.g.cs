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
	public partial interface IShadowL2_Voltage_Samples_75D833AF : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowInputBase_8311D824
	{
		[IoLinkable("Inputs")]
		IShadowU2_Samples_25492287 U2_Samples
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

		new Plc1.PlainL2_Voltage_Samples_75D833AF CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainL2_Voltage_Samples_75D833AF source);
	}
}