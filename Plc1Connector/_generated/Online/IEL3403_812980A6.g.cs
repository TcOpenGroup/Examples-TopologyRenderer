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
	public partial interface IEL3403_812980A6 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IPM_Inputs_Channel_2F868086 PM_Inputs_Channel_1
		{
			get;
		}

		IPM_Inputs_Channel_2F868086 PM_Inputs_Channel_2
		{
			get;
		}

		IPM_Inputs_Channel_2F868086 PM_Inputs_Channel_3
		{
			get;
		}

		IPM_Status_data_2A9514CB PM_Status_data
		{
			get;
		}

		IPM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_1
		{
			get;
		}

		IPM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_2
		{
			get;
		}

		IPM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_3
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

		new Plc1.PlainEL3403_812980A6 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL3403_812980A6 source);
		void FlushOnlineToPlain(Plc1.PlainEL3403_812980A6 source);
	}
}