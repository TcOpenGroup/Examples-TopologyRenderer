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
	public partial interface IShadowEL1008_78E8D3DD : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveTerminalBase_947E5A46
	{
		IShadowChannel_830843C1 Channel_1
		{
			get;
		}

		IShadowChannel_830843C1 Channel_2
		{
			get;
		}

		IShadowChannel_830843C1 Channel_3
		{
			get;
		}

		IShadowChannel_830843C1 Channel_4
		{
			get;
		}

		IShadowChannel_830843C1 Channel_5
		{
			get;
		}

		IShadowChannel_830843C1 Channel_6
		{
			get;
		}

		IShadowChannel_830843C1 Channel_7
		{
			get;
		}

		IShadowChannel_830843C1 Channel_8
		{
			get;
		}

		TcoIo.IShadowWcState_9091E0EB WcState
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

		new Plc1.PlainEL1008_78E8D3DD CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainEL1008_78E8D3DD source);
	}
}