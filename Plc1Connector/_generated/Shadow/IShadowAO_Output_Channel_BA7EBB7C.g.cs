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
	public partial interface IShadowAO_Output_Channel_BA7EBB7C : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt Analog_output
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

		new Plc1.PlainAO_Output_Channel_BA7EBB7C CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainAO_Output_Channel_BA7EBB7C source);
	}
}