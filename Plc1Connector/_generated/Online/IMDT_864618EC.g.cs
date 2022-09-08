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
	public partial interface IMDT_864618EC : Vortex.Connector.IVortexOnlineObject, TcoIo.IOutputBase_10CEE7DE
	{
		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt Master_control_word
		{
			get;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt Position_command_value
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

		new Plc1.PlainMDT_864618EC CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainMDT_864618EC source);
		void FlushOnlineToPlain(Plc1.PlainMDT_864618EC source);
	}
}