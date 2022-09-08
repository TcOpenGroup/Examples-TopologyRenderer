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
	public partial interface ITerm_230_EK1122_16418046 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_231_EK1100_6FCE8CEB Term_231_EK1100
		{
			get;
		}

		ITerm_233_EK1100_CB654C3B Term_233_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_230_EK1122_16418046 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_230_EK1122_16418046 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_230_EK1122_16418046 source);
	}
}