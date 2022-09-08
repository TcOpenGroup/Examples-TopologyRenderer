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
	public partial interface ITerm_207_EK1100_2D36550A : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_230_EK1122_16418046 Term_230_EK1122
		{
			get;
		}

		IEL2008_E2806B95 Term_235_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_236_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_207_EK1100_2D36550A CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_207_EK1100_2D36550A source);
		void FlushOnlineToPlain(Plc1.PlainTerm_207_EK1100_2D36550A source);
	}
}