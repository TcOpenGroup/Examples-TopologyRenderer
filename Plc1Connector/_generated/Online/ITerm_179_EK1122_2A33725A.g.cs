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
	public partial interface ITerm_179_EK1122_2A33725A : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_180_EK1100_796B7783 Term_180_EK1100
		{
			get;
		}

		ITerm_182_EK1100_E6B2C35E Term_182_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_179_EK1122_2A33725A CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_179_EK1122_2A33725A source);
		void FlushOnlineToPlain(Plc1.PlainTerm_179_EK1122_2A33725A source);
	}
}