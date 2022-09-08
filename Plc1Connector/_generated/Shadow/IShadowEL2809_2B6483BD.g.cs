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
	public partial interface IShadowEL2809_2B6483BD : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveTerminalBase_947E5A46
	{
		IShadowChannel_42CA91F7 Channel_1
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_2
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_3
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_4
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_5
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_6
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_7
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_8
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_9
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_10
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_11
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_12
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_13
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_14
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_15
		{
			get;
		}

		IShadowChannel_42CA91F7 Channel_16
		{
			get;
		}

		TcoIo.IShadowWcState_0B2B16F9 WcState
		{
			get;
		}

		TcoIo.IShadowInfoData_6F19DB2B InfoData
		{
			get;
		}

		System.String AttributeVendorId
		{
			get;
		}

		System.String AttributeBoxType
		{
			get;
		}

		System.String AttributeDescription
		{
			get;
		}

		System.String AttributePhysics
		{
			get;
		}

		System.String AttributeId
		{
			get;
		}

		System.String AttributeCRC
		{
			get;
		}

		System.String AttributeSize
		{
			get;
		}

		new Plc1.PlainEL2809_2B6483BD CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainEL2809_2B6483BD source);
	}
}