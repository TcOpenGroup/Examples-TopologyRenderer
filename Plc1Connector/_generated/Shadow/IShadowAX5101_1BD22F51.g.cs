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
	public partial interface IShadowAX5101_1BD22F51 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveBoxBase_77A0E4A7
	{
		IShadowAT_x_4EC2E768 AT_x
		{
			get;
		}

		IShadowMDT_864618EC MDT
		{
			get;
		}

		TcoIo.IShadowWcState_9091E0EB WcState
		{
			get;
		}

		IShadowInfoData_F60A43AC InfoData
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
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainAX5101_1BD22F51 source);
	}
}