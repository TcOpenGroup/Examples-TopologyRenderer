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
	public partial interface IShadowDevice_1_EtherCAT_B557D6C6 : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowEtcMasterBase_62654B43
	{
		IShadowTerm_1_EK1200_B38DC9A8 Term_1_EK1200
		{
			get;
		}

		IShadowSyncUnits_67D36DDA SyncUnits
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

		new Plc1.PlainDevice_1_EtherCAT_B557D6C6 CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainDevice_1_EtherCAT_B557D6C6 source);
	}
}