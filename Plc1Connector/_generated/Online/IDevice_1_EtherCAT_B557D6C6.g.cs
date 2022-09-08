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
	public partial interface IDevice_1_EtherCAT_B557D6C6 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcMasterBase_62654B43
	{
		ITerm_1_EK1200_B38DC9A8 Term_1_EK1200
		{
			get;
		}

		ISyncUnits_67D36DDA SyncUnits
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

		new Plc1.PlainDevice_1_EtherCAT_B557D6C6 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainDevice_1_EtherCAT_B557D6C6 source);
		void FlushOnlineToPlain(Plc1.PlainDevice_1_EtherCAT_B557D6C6 source);
	}
}