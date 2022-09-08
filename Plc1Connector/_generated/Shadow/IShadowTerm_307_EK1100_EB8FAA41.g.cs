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
	public partial interface IShadowTerm_307_EK1100_EB8FAA41 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_330_EK1122_0EDE60FE Term_330_EK1122
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_335_EL2008
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_336_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_307_EK1100_EB8FAA41 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_307_EK1100_EB8FAA41 source);
	}
}