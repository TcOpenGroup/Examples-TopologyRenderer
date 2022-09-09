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
	public partial interface IEL1008_78E8D3DD : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IChannel_830843C1 Channel_1
		{
			get;
		}

		IChannel_830843C1 Channel_2
		{
			get;
		}

		IChannel_830843C1 Channel_3
		{
			get;
		}

		IChannel_830843C1 Channel_4
		{
			get;
		}

		IChannel_830843C1 Channel_5
		{
			get;
		}

		IChannel_830843C1 Channel_6
		{
			get;
		}

		IChannel_830843C1 Channel_7
		{
			get;
		}

		IChannel_830843C1 Channel_8
		{
			get;
		}

		TcoIo.IWcState_9091E0EB WcState
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

		new Plc1.PlainEL1008_78E8D3DD CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL1008_78E8D3DD source);
		void FlushOnlineToPlain(Plc1.PlainEL1008_78E8D3DD source);
	}
}