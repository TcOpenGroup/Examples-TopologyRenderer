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
	public partial interface IEL2788_E2806B95 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IChannel_42CA91F7 Channel_1
		{
			get;
		}

		IChannel_42CA91F7 Channel_2
		{
			get;
		}

		IChannel_42CA91F7 Channel_3
		{
			get;
		}

		IChannel_42CA91F7 Channel_4
		{
			get;
		}

		IChannel_42CA91F7 Channel_5
		{
			get;
		}

		IChannel_42CA91F7 Channel_6
		{
			get;
		}

		IChannel_42CA91F7 Channel_7
		{
			get;
		}

		IChannel_42CA91F7 Channel_8
		{
			get;
		}

		TcoIo.IWcState_0B2B16F9 WcState
		{
			get;
		}

		TcoIo.IInfoData_6F19DB2B InfoData
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

		new Plc1.PlainEL2788_E2806B95 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL2788_E2806B95 source);
		void FlushOnlineToPlain(Plc1.PlainEL2788_E2806B95 source);
	}
}