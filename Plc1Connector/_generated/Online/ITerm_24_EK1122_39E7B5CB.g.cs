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
	public partial interface ITerm_24_EK1122_39E7B5CB : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_25_EK1100_08217EB4 Term_25_EK1100
		{
			get;
		}

		ITerm_28_EK1100_415F4A7E Term_28_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_24_EK1122_39E7B5CB CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_24_EK1122_39E7B5CB source);
		void FlushOnlineToPlain(Plc1.PlainTerm_24_EK1122_39E7B5CB source);
	}
}