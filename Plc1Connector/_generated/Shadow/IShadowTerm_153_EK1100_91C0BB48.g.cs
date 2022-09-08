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
	public partial interface IShadowTerm_153_EK1100_91C0BB48 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_154_EK1122_E57516AE Term_154_EK1122
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_155_EL2008
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_156_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_153_EK1100_91C0BB48 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_153_EK1100_91C0BB48 source);
	}
}