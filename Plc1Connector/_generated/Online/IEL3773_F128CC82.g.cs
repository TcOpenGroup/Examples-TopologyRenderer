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
	public partial interface IEL3773_F128CC82 : Vortex.Connector.IVortexOnlineObject, TcoIo.IEtcSlaveTerminalBase_947E5A46
	{
		IL1_Voltage_Status_7371B043 L1_Voltage_Status
		{
			get;
		}

		IL1_Voltage_Samples_41AEB7FF L1_Voltage_Samples
		{
			get;
		}

		IL1_Current_Status_82DECBF6 L1_Current_Status
		{
			get;
		}

		IL1_Current_Samples_9EC08B3E L1_Current_Samples
		{
			get;
		}

		IL2_Voltage_Status_0D1813FE L2_Voltage_Status
		{
			get;
		}

		IL2_Voltage_Samples_75D833AF L2_Voltage_Samples
		{
			get;
		}

		IL2_Current_Status_FCB7684B L2_Current_Status
		{
			get;
		}

		IL2_Current_Samples_AAB60F6E L2_Current_Samples
		{
			get;
		}

		IL3_Voltage_Status_273F7295 L3_Voltage_Status
		{
			get;
		}

		IL3_Voltage_Samples_660A4F9F L3_Voltage_Samples
		{
			get;
		}

		IL3_Current_Status_D6900920 L3_Current_Status
		{
			get;
		}

		IL3_Current_Samples_B964735E L3_Current_Samples
		{
			get;
		}

		IAI_NextSync1Time_6DC4D296 AI_NextSync1Time
		{
			get;
		}

		IAI_Sample_Count_EA88CAD9 AI_Sample_Count
		{
			get;
		}

		TcoIo.IWcState_9091E0EB WcState
		{
			get;
		}

		IInfoData_B84DBEC5 InfoData
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

		new Plc1.PlainEL3773_F128CC82 CreatePlainerType();
		new void FlushOnlineToShadow();
		void FlushPlainToOnline(Plc1.PlainEL3773_F128CC82 source);
		void FlushOnlineToPlain(Plc1.PlainEL3773_F128CC82 source);
	}
}