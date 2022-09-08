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
	public partial interface ITerm_158_EK1100_E3D699B1 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL1809_32157CFD Term_160_EL1809
		{
			get;
		}

		new Plc1.PlainTerm_158_EK1100_E3D699B1 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_158_EK1100_E3D699B1 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_158_EK1100_E3D699B1 source);
	}
}