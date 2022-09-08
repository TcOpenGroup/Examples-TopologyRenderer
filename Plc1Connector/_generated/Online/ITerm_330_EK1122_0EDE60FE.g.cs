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
	public partial interface ITerm_330_EK1122_0EDE60FE : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_331_EK1100_B9C4E092 Term_331_EK1100
		{
			get;
		}

		ITerm_333_EK1100_1D6F2042 Term_333_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_330_EK1122_0EDE60FE CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_330_EK1122_0EDE60FE source);
		void FlushOnlineToPlain(Plc1.PlainTerm_330_EK1122_0EDE60FE source);
	}
}