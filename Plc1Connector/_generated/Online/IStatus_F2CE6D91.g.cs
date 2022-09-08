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
	public partial interface IStatus_F2CE6D91 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Underrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Overrange
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte Limit_1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte Limit_2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Error
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

		Plc1.PlainStatus_F2CE6D91 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainStatus_F2CE6D91 source);
		void FlushOnlineToPlain(Plc1.PlainStatus_F2CE6D91 source);
	}
}