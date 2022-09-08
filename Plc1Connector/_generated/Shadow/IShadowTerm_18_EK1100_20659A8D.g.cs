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
	public partial interface IShadowTerm_18_EK1100_20659A8D : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowEL1809_32157CFD Term_19_EL1809
		{
			get;
		}

		IShadowEL2809_2B6483BD Term_20_EL2809
		{
			get;
		}

		IShadowEL1809_32157CFD Term_21_EL1809
		{
			get;
		}

		IShadowEL3011_7A495228 Term_22_EL3011
		{
			get;
		}

		IShadowEL9011_D65D3D32 Term_29_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_18_EK1100_20659A8D CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_18_EK1100_20659A8D source);
	}
}