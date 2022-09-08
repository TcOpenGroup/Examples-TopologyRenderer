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
	public partial interface ITerm_333_EK1100_1D6F2042 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL1809_32157CFD Term_334_EL1809
		{
			get;
		}

		new Plc1.PlainTerm_333_EK1100_1D6F2042 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_333_EK1100_1D6F2042 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_333_EK1100_1D6F2042 source);
	}
}