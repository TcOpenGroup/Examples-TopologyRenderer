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
	public partial interface ITerm_178_EK1100_9B7E9852 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_179_EK1122_2A33725A Term_179_EK1122
		{
			get;
		}

		IEL2008_E2806B95 Term_184_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_185_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_178_EK1100_9B7E9852 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_178_EK1100_9B7E9852 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_178_EK1100_9B7E9852 source);
	}
}