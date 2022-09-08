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
	public partial interface ITerm_186_EK1122_75C79D52 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_187_EK1100_648C31BD Term_187_EK1100
		{
			get;
		}

		ITerm_207_EK1100_2D36550A Term_207_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_186_EK1122_75C79D52 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_186_EK1122_75C79D52 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_186_EK1122_75C79D52 source);
	}
}