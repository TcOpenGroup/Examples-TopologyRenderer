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
	public partial interface ITerm_147_EK1122_CA6A5D16 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_153_EK1100_91C0BB48 Term_153_EK1100
		{
			get;
		}

		ITerm_178_EK1100_9B7E9852 Term_178_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_147_EK1122_CA6A5D16 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_147_EK1122_CA6A5D16 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_147_EK1122_CA6A5D16 source);
	}
}