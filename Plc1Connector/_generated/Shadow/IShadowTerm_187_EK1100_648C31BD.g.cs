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
	public partial interface IShadowTerm_187_EK1100_648C31BD : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_188_EK1122_78D8AA43 Term_188_EK1122
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_204_EL2008
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_205_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_187_EK1100_648C31BD CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_187_EK1100_648C31BD source);
	}
}