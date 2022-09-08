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
	public partial interface ITerm_153_EK1100_91C0BB48 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_154_EK1122_E57516AE Term_154_EK1122
		{
			get;
		}

		IEL2008_E2806B95 Term_155_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_156_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_153_EK1100_91C0BB48 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_153_EK1100_91C0BB48 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_153_EK1100_91C0BB48 source);
	}
}