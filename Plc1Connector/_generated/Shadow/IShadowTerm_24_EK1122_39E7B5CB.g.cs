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
	public partial interface IShadowTerm_24_EK1122_39E7B5CB : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_25_EK1100_08217EB4 Term_25_EK1100
		{
			get;
		}

		IShadowTerm_28_EK1100_415F4A7E Term_28_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_24_EK1122_39E7B5CB CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_24_EK1122_39E7B5CB source);
	}
}