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
	public partial interface II2_Samples_25492287 : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_0
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_1
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_2
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_3
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_4
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_5
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_6
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_7
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_8
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt ARRAY_9
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

		Plc1.PlainI2_Samples_25492287 CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainI2_Samples_25492287 source);
		void FlushOnlineToPlain(Plc1.PlainI2_Samples_25492287 source);
	}
}