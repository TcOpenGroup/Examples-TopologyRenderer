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
	public partial interface IShadowTerm_9_EK1100_91BFEC25 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1100_1FC0878B
	{
		IShadowTerm_10_EK1122_3D069EC1 Term_10_EK1122
		{
			get;
		}

		IShadowEL3403_812980A6 Term_34_EL3403
		{
			get;
		}

		IShadowEL6001_0DE01E7E Term_35_EL6001
		{
			get;
		}

		IShadowEL3024_C6E76B5A Term_36_EL3024
		{
			get;
		}

		IShadowEL9011_D65D3D32 Term_33_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_9_EK1100_91BFEC25 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_9_EK1100_91BFEC25 source);
	}
}