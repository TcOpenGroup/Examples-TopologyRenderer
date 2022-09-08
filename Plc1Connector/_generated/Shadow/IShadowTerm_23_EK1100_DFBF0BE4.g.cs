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
	public partial interface IShadowTerm_23_EK1100_DFBF0BE4 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_24_EK1122_39E7B5CB Term_24_EK1122
		{
			get;
		}

		IShadowEL3773_F128CC82 Term_31_EL3773
		{
			get;
		}

		IShadowEL2258_E3B260FA Term_32_EL2258
		{
			get;
		}

		IShadowEL3164_B71BFF42 Term_33_EL3164
		{
			get;
		}

		IShadowEL9011_D65D3D32 Term_32_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_23_EK1100_DFBF0BE4 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_23_EK1100_DFBF0BE4 source);
	}
}