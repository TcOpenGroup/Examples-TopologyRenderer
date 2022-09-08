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
	public partial interface IShadowTerm_25_EK1100_08217EB4 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowEL1819_32157CFD Term_26_EL1819
		{
			get;
		}

		IShadowEL1819_32157CFD Term_27_EL1819
		{
			get;
		}

		IShadowEL9011_D65D3D32 Term_30_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_25_EK1100_08217EB4 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_25_EK1100_08217EB4 source);
	}
}