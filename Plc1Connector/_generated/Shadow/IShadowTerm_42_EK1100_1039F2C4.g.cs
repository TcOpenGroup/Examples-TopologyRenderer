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
	public partial interface IShadowTerm_42_EK1100_1039F2C4 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowEL1008_78E8D3DD Term_43_EL1008
		{
			get;
		}

		IShadowEL1008_78E8D3DD Term_44_EL1008
		{
			get;
		}

		new Plc1.PlainTerm_42_EK1100_1039F2C4 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_42_EK1100_1039F2C4 source);
	}
}