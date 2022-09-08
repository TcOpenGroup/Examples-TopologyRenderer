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
	public partial interface IShadowCtrl_77460BD3 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool Output_buffer_reset
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Manual_output_state
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Force_order
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool Enable_manual_operation
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt Output_order_counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt No_of_output_events
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
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainCtrl_77460BD3 source);
	}
}