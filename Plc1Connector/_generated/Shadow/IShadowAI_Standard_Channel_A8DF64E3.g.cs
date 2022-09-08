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
	public partial interface IShadowAI_Standard_Channel_A8DF64E3 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowInputBase_8311D824
	{
		[IoLinkable("Inputs")]
		IShadowStatus_B0753356 Status
		{
			get;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt Value
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

		new Plc1.PlainAI_Standard_Channel_A8DF64E3 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainAI_Standard_Channel_A8DF64E3 source);
	}
}