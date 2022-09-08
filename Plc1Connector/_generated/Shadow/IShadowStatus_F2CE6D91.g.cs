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
	public partial interface IShadowStatus_F2CE6D91 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Underrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Overrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte Limit_1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte Limit_2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Error
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

		Plc1.PlainStatus_F2CE6D91 CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainStatus_F2CE6D91 source);
	}
}