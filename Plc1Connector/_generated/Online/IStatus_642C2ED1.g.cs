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
	public partial interface IStatus_642C2ED1 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_short_circuit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_buffer_overflow
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte Input_cycle_counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt Output_order_feedback
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt Events_in_output_buffer
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

		Plc1.PlainStatus_642C2ED1 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainStatus_642C2ED1 source);
		void FlushOnlineToPlain(Plc1.PlainStatus_642C2ED1 source);
	}
}