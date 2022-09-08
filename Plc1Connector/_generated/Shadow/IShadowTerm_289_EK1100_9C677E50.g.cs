using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowTerm_289_EK1100_9C677E50 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_237_EK1122_86A8F7BD Term_237_EK1122
		{
			get;
		}

		IShadowEL1809_32157CFD Term_293_EL1809
		{
			get;
		}

		new Plc1.PlainTerm_289_EK1100_9C677E50 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_289_EK1100_9C677E50 source);
	}
}