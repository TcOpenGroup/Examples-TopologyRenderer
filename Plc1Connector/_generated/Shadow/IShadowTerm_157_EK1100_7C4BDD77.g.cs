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
	public partial interface IShadowTerm_157_EK1100_7C4BDD77 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowEL1809_32157CFD Term_159_EL1809
		{
			get;
		}

		new Plc1.PlainTerm_157_EK1100_7C4BDD77 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_157_EK1100_7C4BDD77 source);
	}
}