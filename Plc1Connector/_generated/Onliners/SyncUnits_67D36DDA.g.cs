using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"\" } {attribute addProperty Id \"_defaultAT %I*SyncUnitTasks_4BE0146918\" } {attribute addProperty CRC \"1741909466\" } {attribute addProperty Size \"18\" } {attribute addProperty Name \"\" }", "SyncUnits_67D36DDA", "Plc1", TypeComplexityEnum.Complex)]
	public partial class SyncUnits_67D36DDA : TcoIo.SyncUnitsBase_AD6C35CE, Vortex.Connector.IVortexObject, ISyncUnits_67D36DDA, IShadowSyncUnits_67D36DDA, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		SyncUnitTasks_4BE01469 __default;
		public SyncUnitTasks_4BE01469 _default
		{
			get
			{
				return __default;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_67D36DDA._default
		{
			get
			{
				return _default;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_67D36DDA._default
		{
			get
			{
				return _default;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			_default.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			_default.LazyShadowToOnline();
		}

		public new PlainSyncUnits_67D36DDA CreatePlainerType()
		{
			var cloned = new PlainSyncUnits_67D36DDA();
			base.CreatePlainerType(cloned);
			cloned._default = _default.CreatePlainerType();
			return cloned;
		}

		protected PlainSyncUnits_67D36DDA CreatePlainerType(PlainSyncUnits_67D36DDA cloned)
		{
			base.CreatePlainerType(cloned);
			cloned._default = _default.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainSyncUnits_67D36DDA source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainSyncUnits_67D36DDA source)
		{
			source.CopyPlainToShadow(this);
		}

		public new void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public new void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc1.PlainSyncUnits_67D36DDA source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public System.String AttributeBoxType
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeBoxType, this).Interpolate(this);
			}

			set
			{
				_AttributeBoxType = value;
			}
		}

		private System.String _AttributeBoxType
		{
			get;
			set;
		}

		public System.String AttributeId
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeId, this).Interpolate(this);
			}

			set
			{
				_AttributeId = value;
			}
		}

		private System.String _AttributeId
		{
			get;
			set;
		}

		public System.String AttributeCRC
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeCRC, this).Interpolate(this);
			}

			set
			{
				_AttributeCRC = value;
			}
		}

		private System.String _AttributeCRC
		{
			get;
			set;
		}

		public System.String AttributeSize
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeSize, this).Interpolate(this);
			}

			set
			{
				_AttributeSize = value;
			}
		}

		private System.String _AttributeSize
		{
			get;
			set;
		}

		public SyncUnits_67D36DDA(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__default = new SyncUnitTasks_4BE01469(this, "_default", "_default");
			__default.AttributeName = "_default";
			AttributeBoxType = "";
			AttributeId = "_defaultAT %I*SyncUnitTasks_4BE0146918";
			AttributeCRC = "1741909466";
			AttributeSize = "18";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public SyncUnits_67D36DDA(): base ()
		{
			PexPreConstructorParameterless();
			__default = new SyncUnitTasks_4BE01469();
			__default.AttributeName = "_default";
			AttributeBoxType = "";
			AttributeId = "_defaultAT %I*SyncUnitTasks_4BE0146918";
			AttributeCRC = "1741909466";
			AttributeSize = "18";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSyncUnits_67D36DDA
	{
		public void CopyPlainToCyclic(Plc1.SyncUnits_67D36DDA target)
		{
			base.CopyPlainToCyclic(target);
			_default.CopyPlainToCyclic(target._default);
		}

		public void CopyPlainToCyclic(Plc1.ISyncUnits_67D36DDA target)
		{
			this.CopyPlainToCyclic((Plc1.SyncUnits_67D36DDA)target);
		}

		public void CopyPlainToShadow(Plc1.SyncUnits_67D36DDA target)
		{
			base.CopyPlainToShadow(target);
			_default.CopyPlainToShadow(target._default);
		}

		public void CopyPlainToShadow(Plc1.IShadowSyncUnits_67D36DDA target)
		{
			this.CopyPlainToShadow((Plc1.SyncUnits_67D36DDA)target);
		}

		public void CopyCyclicToPlain(Plc1.SyncUnits_67D36DDA source)
		{
			base.CopyCyclicToPlain(source);
			_default.CopyCyclicToPlain(source._default);
		}

		public void CopyCyclicToPlain(Plc1.ISyncUnits_67D36DDA source)
		{
			this.CopyCyclicToPlain((Plc1.SyncUnits_67D36DDA)source);
		}

		public void CopyShadowToPlain(Plc1.SyncUnits_67D36DDA source)
		{
			base.CopyShadowToPlain(source);
			_default.CopyShadowToPlain(source._default);
		}

		public void CopyShadowToPlain(Plc1.IShadowSyncUnits_67D36DDA source)
		{
			this.CopyShadowToPlain((Plc1.SyncUnits_67D36DDA)source);
		}
	}
}