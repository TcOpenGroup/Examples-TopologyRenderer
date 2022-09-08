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
	public partial interface IShadowEL6001_0DE01E7E : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcSlaveTerminalBase_947E5A46
	{
		IShadowCOM_Inputs_3801C95E COM_Inputs
		{
			get;
		}

		IShadowCOM_Outputs_DEF408EC COM_Outputs
		{
			get;
		}

		TcoIo.IShadowWcState_9091E0EB WcState
		{
			get;
		}

		TcoIo.IShadowInfoData_23CBA837 InfoData
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

		new Plc1.PlainEL6001_0DE01E7E CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainEL6001_0DE01E7E source);
	}
}