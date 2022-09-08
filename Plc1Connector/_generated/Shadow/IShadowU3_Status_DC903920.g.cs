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
	public partial interface IShadowU3_Status_DC903920 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Underrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Overrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte Limit_x
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Sync_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool TxPDO_State
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool TxPDO_Toggle
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

		Plc1.PlainU3_Status_DC903920 CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainU3_Status_DC903920 source);
	}
}