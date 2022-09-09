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
	public partial interface ITerm_42_EK1100_1039F2C4 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL1008_78E8D3DD Term_43_EL1008
		{
			get;
		}

		IEL1008_78E8D3DD Term_44_EL1008
		{
			get;
		}

		new Plc1.PlainTerm_42_EK1100_1039F2C4 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_42_EK1100_1039F2C4 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_42_EK1100_1039F2C4 source);
	}
}