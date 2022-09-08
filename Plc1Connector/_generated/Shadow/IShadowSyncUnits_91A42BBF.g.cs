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
	public partial interface IShadowSyncUnits_91A42BBF : Vortex.Connector.IVortexShadowObject, TcoIo.IShadowSyncUnitsBase_AD6C35CE
	{
		IShadowSyncUnitTasks_4BE01469 _default
		{
			get;
		}

		IShadowSyncUnitTasks_4BE01469 Row_0
		{
			get;
		}

		IShadowSyncUnitTasks_4BE01469 Row_1
		{
			get;
		}

		IShadowSyncUnitTasks_4BE01469 Row_2
		{
			get;
		}

		IShadowSyncUnitTasks_4BE01469 Row_3
		{
			get;
		}

		IShadowSyncUnitTasks_4BE01469 Row_4
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

		new Plc1.PlainSyncUnits_91A42BBF CreatePlainerType();
		new void FlushShadowToOnline();
		void CopyPlainToShadow(Plc1.PlainSyncUnits_91A42BBF source);
	}
}