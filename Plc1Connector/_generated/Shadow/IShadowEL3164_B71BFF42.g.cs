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
	public partial interface IShadowEL3164_B71BFF42 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveTerminalBase_947E5A46
	{
		IShadowAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_1
		{
			get;
		}

		IShadowAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_2
		{
			get;
		}

		IShadowAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_3
		{
			get;
		}

		IShadowAI_Standard_Channel_A8DF64E3 AI_Standard_Channel_4
		{
			get;
		}

		TcoIo.IShadowWcState_9091E0EB WcState
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

		new Plc1.PlainEL3164_B71BFF42 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainEL3164_B71BFF42 source);
	}
}