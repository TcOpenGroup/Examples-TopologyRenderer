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
	public partial interface IShadowTerm_188_EK1122_78D8AA43 : Vortex.Connector.IVortexShadowObject, Plc1.IShadowEK1122_1FC0878B
	{
		IShadowTerm_189_EK1100_06A16014 Term_189_EK1100
		{
			get;
		}

		IShadowTerm_194_EK1100_D4E2C05F Term_194_EK1100
		{
			get;
		}

		new Plc1.PlainTerm_188_EK1122_78D8AA43 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainTerm_188_EK1122_78D8AA43 source);
	}
}