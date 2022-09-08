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
	public partial interface IGVL_iXlinker : Vortex.Connector.IVortexOnlineObject
	{
		IDevice_1_EtherCAT_B557D6C6 Device_1_EtherCAT
		{
			get;
		}

		IDevice_2_EtherCAT_A8CEDE28 Device_2_EtherCAT
		{
			get;
		}

		IDevice_3_EtherCAT_CA191EDE Device_3_EtherCAT
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc1.PlainGVL_iXlinker CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainGVL_iXlinker source);
		void FlushOnlineToPlain(Plc1.PlainGVL_iXlinker source);
	}
}