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
	public partial interface IShadowEL4004_E203F875 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveTerminalBase_947E5A46
	{
		IShadowAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_1
		{
			get;
		}

		IShadowAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_2
		{
			get;
		}

		IShadowAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_3
		{
			get;
		}

		IShadowAO_Output_Channel_BA7EBB7C AO_Outputs_Channel_4
		{
			get;
		}

		TcoIo.IShadowWcState_0B2B16F9 WcState
		{
			get;
		}

		TcoIo.IShadowInfoData_23CBA837 InfoData
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
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainEL4004_E203F875 source);
	}
}