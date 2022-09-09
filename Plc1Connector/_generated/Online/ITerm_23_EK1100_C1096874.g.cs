using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ITerm_23_EK1100_C1096874 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_24_EK1122_39E7B5CB Term_24_EK1122
		{
			get;
		}

		IEL3773_F128CC82 Term_31_EL3773
		{
			get;
		}

		IEL2258_E3B260FA Term_32_EL2258
		{
			get;
		}

		IEL3164_B71BFF42 Term_33_EL3164
		{
			get;
		}

		IEK1110_1FC0878B Term_40_EK1110
		{
			get;
		}

		new Plc1.PlainTerm_23_EK1100_C1096874 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_23_EK1100_C1096874 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_23_EK1100_C1096874 source);
	}
}