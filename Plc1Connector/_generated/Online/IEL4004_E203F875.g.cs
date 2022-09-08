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
	public partial interface IEL4004_E203F875 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_1
		{
			get;
		}

		IAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_2
		{
			get;
		}

		IAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_3
		{
			get;
		}

		IAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_4
		{
			get;
		}

		TcoIo.IWcState_0B2B16F9 WcState
		{
			get;
		}

		TcoIo.IInfoData_23CBA837 InfoData
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

		new Plc1.PlainEL4004_E203F875 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL4004_E203F875 source);
		void FlushOnlineToPlain(Plc1.PlainEL4004_E203F875 source);
	}
}