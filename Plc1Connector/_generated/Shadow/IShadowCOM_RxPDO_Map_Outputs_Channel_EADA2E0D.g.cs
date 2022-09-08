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
	public partial interface IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		IShadowCtrl_1EFB4D3B Ctrl
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt[] Data_Out
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

		new Plc1.PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D source);
	}
}