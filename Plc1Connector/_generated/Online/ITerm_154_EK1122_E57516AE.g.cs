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
	public partial interface ITerm_154_EK1122_E57516AE : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_157_EK1100_7C4BDD77 Term_157_EK1100
		{
			get;
		}

		ITerm_158_EK1100_E3D699B1 Term_158_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_154_EK1122_E57516AE CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_154_EK1122_E57516AE source);
		void FlushOnlineToPlain(Plc1.PlainTerm_154_EK1122_E57516AE source);
	}
}