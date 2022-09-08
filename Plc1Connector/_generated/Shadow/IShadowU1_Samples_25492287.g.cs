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
	public partial interface IShadowU1_Samples_25492287 : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_0
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_3
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_4
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_5
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_6
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_7
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_8
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt ARRAY_9
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

		Plc1.PlainU1_Samples_25492287 CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainU1_Samples_25492287 source);
	}
}