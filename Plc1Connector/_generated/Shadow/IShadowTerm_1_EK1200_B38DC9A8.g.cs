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
	public partial interface IShadowTerm_1_EK1200_B38DC9A8 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1200_013D0B49
	{
		IShadowEL6002_CD897635 Term_2_EL6002
		{
			get;
		}

		IShadowEL1809_32157CFD Term_3_EL1809
		{
			get;
		}

		IShadowEL2809_2B6483BD Term_4_EL2809
		{
			get;
		}

		IShadowEL4004_E203F875 Term_5_EL4004
		{
			get;
		}

		IShadowEL2809_2B6483BD Term_6_EL2809
		{
			get;
		}

		IShadowEL6001_0DE01E7E Term_7_EL6001
		{
			get;
		}

		IShadowEL9011_D65D3D32 Term_8_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_1_EK1200_B38DC9A8 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_1_EK1200_B38DC9A8 source);
	}
}