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
	public partial interface IShadowTerm_11_EK1100_B6553301 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowEL3174_B71BFF42 Term_12_EL3174_0002
		{
			get;
		}

		IShadowEL6001_0DE01E7E Term_13_EL6001
		{
			get;
		}

		IShadowEL3011_7A495228 Term_14_EL3011
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_15_EL2008
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_16_EL2008
		{
			get;
		}

		IShadowEK1110_1FC0878B Term_17_EK1110
		{
			get;
		}

		new Plc1.PlainTerm_11_EK1100_B6553301 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_11_EK1100_B6553301 source);
	}
}