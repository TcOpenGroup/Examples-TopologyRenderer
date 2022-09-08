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
	public partial interface IShadowTerm_230_EK1122_16418046 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_231_EK1100_6FCE8CEB Term_231_EK1100
		{
			get;
		}

		IShadowTerm_233_EK1100_CB654C3B Term_233_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_230_EK1122_16418046 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_230_EK1122_16418046 source);
	}
}