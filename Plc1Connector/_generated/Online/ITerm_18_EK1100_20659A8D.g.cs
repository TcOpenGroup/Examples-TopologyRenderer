using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface ITerm_18_EK1100_20659A8D : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL1809_32157CFD Term_19_EL1809
		{
			get;
		}

		IEL2809_2B6483BD Term_20_EL2809
		{
			get;
		}

		IEL1809_32157CFD Term_21_EL1809
		{
			get;
		}

		IEL3011_7A495228 Term_22_EL3011
		{
			get;
		}

		IEL9011_D65D3D32 Term_29_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_18_EK1100_20659A8D CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_18_EK1100_20659A8D source);
		void FlushOnlineToPlain(Plc1.PlainTerm_18_EK1100_20659A8D source);
	}
}