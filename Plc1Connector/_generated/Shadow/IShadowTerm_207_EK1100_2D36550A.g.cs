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
	public partial interface IShadowTerm_207_EK1100_2D36550A : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_230_EK1122_16418046 Term_230_EK1122
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_235_EL2008
		{
			get;
		}

		IShadowEL2008_E2806B95 Term_236_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_207_EK1100_2D36550A CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_207_EK1100_2D36550A source);
	}
}