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
	public partial interface IShadowGVL_iXlinker : Vortex.Connector.IVortexShadowObject
	{
		IShadowDevice_1_EtherCAT_B557D6C6 Device_1_EtherCAT
		{
			get;
		}

		IShadowDevice_2_EtherCAT_CA128DDC Device_2_EtherCAT
		{
			get;
		}

		IShadowDevice_3_EtherCAT_CA191EDE Device_3_EtherCAT
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		Plc1.PlainGVL_iXlinker CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainGVL_iXlinker source);
	}
}