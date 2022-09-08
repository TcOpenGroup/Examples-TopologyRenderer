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
	public partial interface ITerm_146_EK1100_439F5464 : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1100_1FC0878B
	{
		ITerm_147_EK1122_CA6A5D16 Term_147_EK1122
		{
			get;
		}

		ITerm_186_EK1122_75C79D52 Term_186_EK1122
		{
			get;
		}

		IEL1809_32157CFD Term_148_EL1809
		{
			get;
		}

		IEL1809_32157CFD Term_149_EL1809
		{
			get;
		}

		IEL1809_32157CFD Term_150_EL1809
		{
			get;
		}

		IEL1809_32157CFD Term_151_EL1809
		{
			get;
		}

		IEL1809_32157CFD Term_152_EL1809
		{
			get;
		}

		ITerm_288_EK1122_18F8921F Term_288_EK1122
		{
			get;
		}

		IEL2008_E2806B95 Term_1158_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_1159_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_1160_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_1161_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_1162_EL2008
		{
			get;
		}

		IEL2008_E2806B95 Term_1163_EL2008
		{
			get;
		}

		new Plc1.PlainTerm_146_EK1100_439F5464 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_146_EK1100_439F5464 source);
		void FlushOnlineToPlain(Plc1.PlainTerm_146_EK1100_439F5464 source);
	}
}