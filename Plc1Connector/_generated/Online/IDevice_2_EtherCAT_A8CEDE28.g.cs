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
	public partial interface IDevice_2_EtherCAT_A8CEDE28 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcMasterBase_62654B43
	{
		ITerm_9_EK1100_91BFEC25 Term_9_EK1100
		{
			get;
		}

		ISyncUnits_91A42BBF SyncUnits
		{
			get;
		}

		TcoIo.IInputs_A65FACA4 Inputs
		{
			get;
		}

		TcoIo.IOutputs_23C0ED1D Outputs
		{
			get;
		}

		TcoIo.IInfoData_84133AC9 InfoData
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
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainDevice_2_EtherCAT_A8CEDE28 source);
		void FlushOnlineToPlain(Plc1.PlainDevice_2_EtherCAT_A8CEDE28 source);
	}
}