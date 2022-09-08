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
	public partial interface IShadowEL2258_E3B260FA : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveTerminalBase_947E5A46
	{
		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_1
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_2
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_3
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_4
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_5
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_6
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_7
		{
			get;
		}

		IShadowMTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_8
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_1
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_2
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_3
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_4
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_5
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_6
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_7
		{
			get;
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_8
		{
			get;
		}

		TcoIo.IShadowWcState_9091E0EB WcState
		{
			get;
		}

		IShadowInfoData_B84DBEC5 InfoData
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
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainEL2258_E3B260FA source);
	}
}