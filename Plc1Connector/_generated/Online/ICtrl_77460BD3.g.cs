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
	public partial interface ICtrl_77460BD3 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_buffer_reset
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Manual_output_state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Force_order
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Enable_manual_operation
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt Output_order_counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt No_of_output_events
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

		Plc1.PlainCtrl_77460BD3 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainCtrl_77460BD3 source);
		void FlushOnlineToPlain(Plc1.PlainCtrl_77460BD3 source);
	}
}