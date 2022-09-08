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
	public partial interface IEL6002_CD897635 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		ICOM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_1
		{
			get;
		}

		ICOM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_2
		{
			get;
		}

		ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_1
		{
			get;
		}

		ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_2
		{
			get;
		}

		TcoIo.IWcState_9091E0EB WcState
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

		new Plc1.PlainEL6002_CD897635 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL6002_CD897635 source);
		void FlushOnlineToPlain(Plc1.PlainEL6002_CD897635 source);
	}
}