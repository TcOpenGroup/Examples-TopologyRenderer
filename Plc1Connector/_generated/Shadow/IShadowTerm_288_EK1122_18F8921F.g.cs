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
	public partial interface IShadowTerm_288_EK1122_18F8921F : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_289_EK1100_9C677E50 Term_289_EK1100
		{
			get;
		}

		IShadowTerm_294_EK1100_DFE2A59E Term_294_EK1100
		{
			get;
		}

		IShadowTerm_307_EK1100_EB8FAA41 Term_307_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_288_EK1122_18F8921F CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_288_EK1122_18F8921F source);
	}
}