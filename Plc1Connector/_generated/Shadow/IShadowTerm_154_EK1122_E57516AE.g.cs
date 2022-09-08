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
	public partial interface IShadowTerm_154_EK1122_E57516AE : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_157_EK1100_7C4BDD77 Term_157_EK1100
		{
			get;
		}

		IShadowTerm_158_EK1100_E3D699B1 Term_158_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_154_EK1122_E57516AE CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_154_EK1122_E57516AE source);
	}
}