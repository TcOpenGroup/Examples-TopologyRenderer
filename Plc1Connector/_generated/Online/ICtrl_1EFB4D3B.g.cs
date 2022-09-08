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
	public partial interface ICtrl_1EFB4D3B : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Transmit_request
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Receive_accepted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Init_request
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Send_continuous
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt Output_length
		{
			get;
		}

		System.String AttributeBoxType
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

		System.String AttributeName
		{
			get;
		}

		Plc1.PlainCtrl_1EFB4D3B CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainCtrl_1EFB4D3B source);
		void FlushOnlineToPlain(Plc1.PlainCtrl_1EFB4D3B source);
	}
}