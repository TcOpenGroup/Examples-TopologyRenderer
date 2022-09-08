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
	public partial interface IShadowTerm_186_EK1122_75C79D52 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_187_EK1100_648C31BD Term_187_EK1100
		{
			get;
		}

		IShadowTerm_207_EK1100_2D36550A Term_207_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_186_EK1122_75C79D52 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_186_EK1122_75C79D52 source);
	}
}