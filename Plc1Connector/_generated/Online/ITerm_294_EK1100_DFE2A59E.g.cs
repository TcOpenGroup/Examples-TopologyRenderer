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
	public partial interface ITerm_294_EK1100_DFE2A59E : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL1809_32157CFD Term_300_EL1809
		{
			get;
		}

		IEL2008_E2806B95 Term_304_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_305_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_294_EK1100_DFE2A59E CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_294_EK1100_DFE2A59E source);
		void FlushOnlineToPlain(Plc1.PlainTerm_294_EK1100_DFE2A59E source);
	}
}