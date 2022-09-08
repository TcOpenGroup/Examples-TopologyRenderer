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
	public partial interface IShadowDevice_2_EtherCAT_A8CEDE28 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcMasterBase_62654B43
	{
		IShadowTerm_9_EK1100_91BFEC25 Term_9_EK1100
		{
			get;
		}

		IShadowSyncUnits_91A42BBF SyncUnits
		{
			get;
		}

		TcoIo.IShadowInputs_A65FACA4 Inputs
		{
			get;
		}

		TcoIo.IShadowOutputs_23C0ED1D Outputs
		{
			get;
		}

		TcoIo.IShadowInfoData_84133AC9 InfoData
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

		new Plc1.PlainDevice_2_EtherCAT_A8CEDE28 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainDevice_2_EtherCAT_A8CEDE28 source);
	}
}