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
	public partial interface IAX5101_1BD22F51 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveBoxBase_77A0E4A7
	{
		IAT_x_4EC2E768 AT_x
		{
			get;
		}

		IMDT_864618EC MDT
		{
			get;
		}

		TcoIo.IWcState_9091E0EB WcState
		{
			get;
		}

		IInfoData_F60A43AC InfoData
		{
			get;
		}

		System.String AttributeVendorId
		{
			get;
		}

		System.String AttributeBoxType
		{
			get;
		}

		System.String AttributeDescription
		{
			get;
		}

		System.String AttributePhysics
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

		new Plc1.PlainAX5101_1BD22F51 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainAX5101_1BD22F51 source);
		void FlushOnlineToPlain(Plc1.PlainAX5101_1BD22F51 source);
	}
}