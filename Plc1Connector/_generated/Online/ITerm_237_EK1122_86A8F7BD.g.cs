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
	public partial interface ITerm_237_EK1122_86A8F7BD : Vortex.Connector.IVortexOnlineObject, Plc1.IEK1122_1FC0878B
	{
		IAX5101_1BD22F51 Drive_238_AX5101_0000_0214
		{
			get;
		}

		new Plc1.PlainTerm_237_EK1122_86A8F7BD CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainTerm_237_EK1122_86A8F7BD source);
		void FlushOnlineToPlain(Plc1.PlainTerm_237_EK1122_86A8F7BD source);
	}
}