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
	public partial interface IShadowStatus_642C2ED1 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Output_short_circuit
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Output_buffer_overflow
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Output_state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte Input_cycle_counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt Output_order_feedback
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt Events_in_output_buffer
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
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainStatus_642C2ED1 source);
	}
}