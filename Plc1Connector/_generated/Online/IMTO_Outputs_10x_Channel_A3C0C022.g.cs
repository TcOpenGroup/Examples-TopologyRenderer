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
	public partial interface IMTO_Outputs_10x_Channel_A3C0C022 : Vortex.Connector.IVortexOnlineObject, TcoIo.IOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		ICtrl_77460BD3 Ctrl
		{
			get;
		}

		[IoLinkable("Outputs")]
		IOutputs_A910484D Outputs
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt[] Output_event_time
		{
			get;
			set;
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

		new Plc1.PlainMTO_Outputs_10x_Channel_A3C0C022 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainMTO_Outputs_10x_Channel_A3C0C022 source);
		void FlushOnlineToPlain(Plc1.PlainMTO_Outputs_10x_Channel_A3C0C022 source);
	}
}