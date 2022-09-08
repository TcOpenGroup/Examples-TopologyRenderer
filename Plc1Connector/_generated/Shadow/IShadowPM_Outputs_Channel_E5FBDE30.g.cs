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
	public partial interface IShadowPM_Outputs_Channel_E5FBDE30 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt Index
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

		new Plc1.PlainPM_Outputs_Channel_E5FBDE30 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainPM_Outputs_Channel_E5FBDE30 source);
	}
}