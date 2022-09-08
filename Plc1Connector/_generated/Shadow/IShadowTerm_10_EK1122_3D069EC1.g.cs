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
	public partial interface IShadowTerm_10_EK1122_3D069EC1 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_11_EK1100_B6553301 Term_11_EK1100
		{
			get;
		}

		IShadowTerm_18_EK1100_20659A8D Term_18_EK1100
		{
			get;
		}

		IShadowTerm_23_EK1100_DFBF0BE4 Term_23_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_10_EK1122_3D069EC1 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_10_EK1122_3D069EC1 source);
	}
}