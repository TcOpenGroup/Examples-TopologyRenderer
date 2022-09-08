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
	public partial interface IDevice_3_EtherCAT_CA191EDE : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcMasterBase_62654B43
	{
		ITerm_146_EK1100_439F5464 Term_146_EK1100
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

		new Plc1.PlainDevice_3_EtherCAT_CA191EDE CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainDevice_3_EtherCAT_CA191EDE source);
		void FlushOnlineToPlain(Plc1.PlainDevice_3_EtherCAT_CA191EDE source);
	}
}