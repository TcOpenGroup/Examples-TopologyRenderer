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
	public partial interface IShadowTerm_330_EK1122_0EDE60FE : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_331_EK1100_B9C4E092 Term_331_EK1100
		{
			get;
		}

		IShadowTerm_333_EK1100_1D6F2042 Term_333_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_330_EK1122_0EDE60FE CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_330_EK1122_0EDE60FE source);
	}
}