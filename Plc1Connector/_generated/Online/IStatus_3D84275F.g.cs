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
	public partial interface IStatus_3D84275F : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Transmit_accepted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Receive_request
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Init_accepted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Buffer_full
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Parity_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Framing_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Overrun_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt Input_length
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

		Plc1.PlainStatus_3D84275F CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainStatus_3D84275F source);
		void FlushOnlineToPlain(Plc1.PlainStatus_3D84275F source);
	}
}