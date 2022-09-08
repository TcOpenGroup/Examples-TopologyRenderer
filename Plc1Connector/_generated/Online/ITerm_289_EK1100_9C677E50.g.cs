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
	public partial interface ITerm_289_EK1100_9C677E50 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_237_EK1122_86A8F7BD Term_237_EK1122
		{
			get;
		}

		IEL1809_32157CFD Term_293_EL1809
		{
			get;
		}

		new Plc1.PlainTerm_289_EK1100_9C677E50 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_289_EK1100_9C677E50 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_289_EK1100_9C677E50 source);
	}
}