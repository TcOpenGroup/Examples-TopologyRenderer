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
	public partial interface IEL2258_E3B260FA : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_1
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_2
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_3
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_4
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_5
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_6
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_7
		{
			get;
		}

		IMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_8
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_1
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_2
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_3
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_4
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_5
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_6
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_7
		{
			get;
		}

		IMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_8
		{
			get;
		}

		TcoIo.IWcState_9091E0EB WcState
		{
			get;
		}

		IInfoData_B84DBEC5 InfoData
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

		new Plc1.PlainEL2258_E3B260FA CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL2258_E3B260FA source);
		void FlushOnlineToPlain(Plc1.PlainEL2258_E3B260FA source);
	}
}