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
	public partial interface ICOM_Outputs_DEF408EC : Vortex.Connector.IVortexOnlineObject, TcoIo.IOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		ICtrl_71604E86 Ctrl
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt[] Data_Out
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

		new Plc1.PlainCOM_Outputs_DEF408EC CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainCOM_Outputs_DEF408EC source);
		void FlushOnlineToPlain(Plc1.PlainCOM_Outputs_DEF408EC source);
	}
}