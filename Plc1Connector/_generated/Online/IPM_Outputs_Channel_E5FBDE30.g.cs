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
	public partial interface IPM_Outputs_Channel_E5FBDE30 : Vortex.Connector.IVortexOnlineObject, TcoIo.IOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt Index
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
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainPM_Outputs_Channel_E5FBDE30 source);
		void FlushOnlineToPlain(Plc1.PlainPM_Outputs_Channel_E5FBDE30 source);
	}
}