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
	public partial interface IShadowTerm_23_EK1100_C1096874 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
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

		IShadowEK1110_1FC0878B Term_40_EK1110
		{
			get;
		}

		new Plc1.PlainTerm_23_EK1100_C1096874 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_23_EK1100_C1096874 source);
	}
}