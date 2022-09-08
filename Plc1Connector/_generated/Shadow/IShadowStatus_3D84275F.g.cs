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
	public partial interface IShadowStatus_3D84275F : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Transmit_accepted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Receive_request
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Init_accepted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Buffer_full
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Parity_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Framing_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Overrun_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt Input_length
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
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainStatus_3D84275F source);
	}
}