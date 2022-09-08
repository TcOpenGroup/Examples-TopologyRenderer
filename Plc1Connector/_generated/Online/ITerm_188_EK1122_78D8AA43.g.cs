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
	public partial interface ITerm_188_EK1122_78D8AA43 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		ITerm_189_EK1100_06A16014 Term_189_EK1100
		{
			get;
		}

		ITerm_194_EK1100_D4E2C05F Term_194_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_188_EK1122_78D8AA43 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_188_EK1122_78D8AA43 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_188_EK1122_78D8AA43 source);
	}
}