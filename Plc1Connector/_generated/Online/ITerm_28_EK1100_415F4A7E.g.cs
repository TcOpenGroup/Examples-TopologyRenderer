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
	public partial interface ITerm_28_EK1100_415F4A7E : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		IEL2788_E2806B95 Term_29_EL2788
		{
			get;
		}

		IEL3773_F128CC82 Term_30_EL3773
		{
			get;
		}

		IEL9011_D65D3D32 Term_31_EL9011
		{
			get;
		}

		new Plc1.PlainTerm_28_EK1100_415F4A7E CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_28_EK1100_415F4A7E source);
		void FlushOnlineToPlain(Plc1.PlainTerm_28_EK1100_415F4A7E source);
	}
}