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
	public partial interface ITerm_187_EK1100_648C31BD : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_188_EK1122_78D8AA43 Term_188_EK1122
		{
			get;
		}

		IEL2008_E2806B95 Term_204_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_205_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_187_EK1100_648C31BD CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_187_EK1100_648C31BD source);
		void FlushOnlineToPlain(Plc1.PlainTerm_187_EK1100_648C31BD source);
	}
}