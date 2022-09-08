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
	public partial interface ITerm_307_EK1100_EB8FAA41 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_330_EK1122_0EDE60FE Term_330_EK1122
		{
			get;
		}

		IEL2008_E2806B95 Term_335_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_336_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_307_EK1100_EB8FAA41 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_307_EK1100_EB8FAA41 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_307_EK1100_EB8FAA41 source);
	}
}