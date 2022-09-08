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
	public partial interface IShadowTerm_28_EK1100_415F4A7E : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowEL2788_E2806B95 Term_29_EL2788
		{
			get;
		}

		IShadowEL3773_F128CC82 Term_30_EL3773
		{
			get;
		}

		IShadowEL9011_D65D3D32 Term_31_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_28_EK1100_415F4A7E CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_28_EK1100_415F4A7E source);
	}
}