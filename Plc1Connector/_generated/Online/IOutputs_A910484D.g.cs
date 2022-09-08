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
	public partial interface IOutputs_A910484D : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_3
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_4
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_5
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_6
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_7
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_8
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_9
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool Output_event_state_10
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

		Plc1.PlainOutputs_A910484D CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainOutputs_A910484D source);
		void FlushOnlineToPlain(Plc1.PlainOutputs_A910484D source);
	}
}