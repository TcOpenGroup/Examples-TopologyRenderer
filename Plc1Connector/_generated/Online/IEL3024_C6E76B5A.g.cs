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
	public partial interface IEL3024_C6E76B5A : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IAI_Standard_Channel_4A394481 AI_Standard_Channel_1
		{
			get;
		}

		IAI_Standard_Channel_4A394481 AI_Standard_Channel_2
		{
			get;
		}

		IAI_Standard_Channel_4A394481 AI_Standard_Channel_3
		{
			get;
		}

		IAI_Standard_Channel_4A394481 AI_Standard_Channel_4
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

		new Plc1.PlainEL3024_C6E76B5A CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL3024_C6E76B5A source);
		void FlushOnlineToPlain(Plc1.PlainEL3024_C6E76B5A source);
	}
}