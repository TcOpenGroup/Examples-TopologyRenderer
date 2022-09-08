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
	public partial interface II3_Status_DC903920 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Underrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Overrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte Limit_x
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Sync_error
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool TxPDO_State
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool TxPDO_Toggle
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

		Plc1.PlainI3_Status_DC903920 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainI3_Status_DC903920 source);
		void FlushOnlineToPlain(Plc1.PlainI3_Status_DC903920 source);
	}
}