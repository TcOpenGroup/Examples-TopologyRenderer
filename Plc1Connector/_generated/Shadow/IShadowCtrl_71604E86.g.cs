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
	public partial interface IShadowCtrl_71604E86 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Transmit_request
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Receive_accepted
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Init_request
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Send_continues
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt Output_length
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

		Plc1.PlainCtrl_71604E86 CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainCtrl_71604E86 source);
	}
}