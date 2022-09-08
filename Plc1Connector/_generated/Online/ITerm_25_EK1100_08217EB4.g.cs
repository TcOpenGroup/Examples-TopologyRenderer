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
	public partial interface ITerm_25_EK1100_08217EB4 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL1819_32157CFD Term_26_EL1819
		{
			get;
		}

		IEL1819_32157CFD Term_27_EL1819
		{
			get;
		}

		IEL9011_D65D3D32 Term_30_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_25_EK1100_08217EB4 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_25_EK1100_08217EB4 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_25_EK1100_08217EB4 source);
	}
}