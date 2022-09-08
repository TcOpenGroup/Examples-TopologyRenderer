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
	public partial interface IShadowTerm_179_EK1122_2A33725A : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_180_EK1100_796B7783 Term_180_EK1100
		{
			get;
		}

		IShadowTerm_182_EK1100_E6B2C35E Term_182_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_179_EK1122_2A33725A CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_179_EK1122_2A33725A source);
	}
}