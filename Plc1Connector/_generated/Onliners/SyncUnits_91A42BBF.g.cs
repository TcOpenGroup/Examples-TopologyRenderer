using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"\" } {attribute addProperty Id \"_defaultAT %I*SyncUnitTasks_4BE0146918Row_0AT %I*SyncUnitTasks_4BE0146918Row_1AT %I*SyncUnitTasks_4BE0146918Row_2AT %I*SyncUnitTasks_4BE0146918Row_3AT %I*SyncUnitTasks_4BE0146918Row_4AT %I*SyncUnitTasks_4BE0146918\" } {attribute addProperty CRC \"2443455423\" } {attribute addProperty Size \"108\" } {attribute addProperty Name \"\" }", "SyncUnits_91A42BBF", "Plc1", TypeComplexityEnum.Complex)]
	public partial class SyncUnits_91A42BBF : TcoIo.SyncUnitsBase_AD6C35CE, Vortex.Connector.IVortexObject, ISyncUnits_91A42BBF, IShadowSyncUnits_91A42BBF, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		SyncUnitTasks_4BE01469 __default;
		public SyncUnitTasks_4BE01469 _default
		{
			get
			{
				return __default;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_91A42BBF._default
		{
			get
			{
				return _default;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_91A42BBF._default
		{
			get
			{
				return _default;
			}
		}

		SyncUnitTasks_4BE01469 _Row_0;
		public SyncUnitTasks_4BE01469 Row_0
		{
			get
			{
				return _Row_0;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_91A42BBF.Row_0
		{
			get
			{
				return Row_0;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_91A42BBF.Row_0
		{
			get
			{
				return Row_0;
			}
		}

		SyncUnitTasks_4BE01469 _Row_1;
		public SyncUnitTasks_4BE01469 Row_1
		{
			get
			{
				return _Row_1;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_91A42BBF.Row_1
		{
			get
			{
				return Row_1;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_91A42BBF.Row_1
		{
			get
			{
				return Row_1;
			}
		}

		SyncUnitTasks_4BE01469 _Row_2;
		public SyncUnitTasks_4BE01469 Row_2
		{
			get
			{
				return _Row_2;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_91A42BBF.Row_2
		{
			get
			{
				return Row_2;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_91A42BBF.Row_2
		{
			get
			{
				return Row_2;
			}
		}

		SyncUnitTasks_4BE01469 _Row_3;
		public SyncUnitTasks_4BE01469 Row_3
		{
			get
			{
				return _Row_3;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_91A42BBF.Row_3
		{
			get
			{
				return Row_3;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_91A42BBF.Row_3
		{
			get
			{
				return Row_3;
			}
		}

		SyncUnitTasks_4BE01469 _Row_4;
		public SyncUnitTasks_4BE01469 Row_4
		{
			get
			{
				return _Row_4;
			}
		}

		ISyncUnitTasks_4BE01469 ISyncUnits_91A42BBF.Row_4
		{
			get
			{
				return Row_4;
			}
		}

		IShadowSyncUnitTasks_4BE01469 IShadowSyncUnits_91A42BBF.Row_4
		{
			get
			{
				return Row_4;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			_default.LazyOnlineToShadow();
			Row_0.LazyOnlineToShadow();
			Row_1.LazyOnlineToShadow();
			Row_2.LazyOnlineToShadow();
			Row_3.LazyOnlineToShadow();
			Row_4.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			_default.LazyShadowToOnline();
			Row_0.LazyShadowToOnline();
			Row_1.LazyShadowToOnline();
			Row_2.LazyShadowToOnline();
			Row_3.LazyShadowToOnline();
			Row_4.LazyShadowToOnline();
		}

		public new PlainSyncUnits_91A42BBF CreatePlainerType()
		{
			var cloned = new PlainSyncUnits_91A42BBF();
			base.CreatePlainerType(cloned);
			cloned._default = _default.CreatePlainerType();
			cloned.Row_0 = Row_0.CreatePlainerType();
			cloned.Row_1 = Row_1.CreatePlainerType();
			cloned.Row_2 = Row_2.CreatePlainerType();
			cloned.Row_3 = Row_3.CreatePlainerType();
			cloned.Row_4 = Row_4.CreatePlainerType();
			return cloned;
		}

		protected PlainSyncUnits_91A42BBF CreatePlainerType(PlainSyncUnits_91A42BBF cloned)
		{
			base.CreatePlainerType(cloned);
			cloned._default = _default.CreatePlainerType();
			cloned.Row_0 = Row_0.CreatePlainerType();
			cloned.Row_1 = Row_1.CreatePlainerType();
			cloned.Row_2 = Row_2.CreatePlainerType();
			cloned.Row_3 = Row_3.CreatePlainerType();
			cloned.Row_4 = Row_4.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainSyncUnits_91A42BBF source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainSyncUnits_91A42BBF source)
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

		public void FlushOnlineToPlain(Plc1.PlainSyncUnits_91A42BBF source)
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

		public SyncUnits_91A42BBF(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__default = new SyncUnitTasks_4BE01469(this, "_default", "_default");
			__default.AttributeName = "_default";
			_Row_0 = new SyncUnitTasks_4BE01469(this, "Row_0", "Row_0");
			_Row_0.AttributeName = "Row_0";
			_Row_1 = new SyncUnitTasks_4BE01469(this, "Row_1", "Row_1");
			_Row_1.AttributeName = "Row_1";
			_Row_2 = new SyncUnitTasks_4BE01469(this, "Row_2", "Row_2");
			_Row_2.AttributeName = "Row_2";
			_Row_3 = new SyncUnitTasks_4BE01469(this, "Row_3", "Row_3");
			_Row_3.AttributeName = "Row_3";
			_Row_4 = new SyncUnitTasks_4BE01469(this, "Row_4", "Row_4");
			_Row_4.AttributeName = "Row_4";
			AttributeBoxType = "";
			AttributeId = "_defaultAT %I*SyncUnitTasks_4BE0146918Row_0AT %I*SyncUnitTasks_4BE0146918Row_1AT %I*SyncUnitTasks_4BE0146918Row_2AT %I*SyncUnitTasks_4BE0146918Row_3AT %I*SyncUnitTasks_4BE0146918Row_4AT %I*SyncUnitTasks_4BE0146918";
			AttributeCRC = "2443455423";
			AttributeSize = "108";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public SyncUnits_91A42BBF(): base ()
		{
			PexPreConstructorParameterless();
			__default = new SyncUnitTasks_4BE01469();
			__default.AttributeName = "_default";
			_Row_0 = new SyncUnitTasks_4BE01469();
			_Row_0.AttributeName = "Row_0";
			_Row_1 = new SyncUnitTasks_4BE01469();
			_Row_1.AttributeName = "Row_1";
			_Row_2 = new SyncUnitTasks_4BE01469();
			_Row_2.AttributeName = "Row_2";
			_Row_3 = new SyncUnitTasks_4BE01469();
			_Row_3.AttributeName = "Row_3";
			_Row_4 = new SyncUnitTasks_4BE01469();
			_Row_4.AttributeName = "Row_4";
			AttributeBoxType = "";
			AttributeId = "_defaultAT %I*SyncUnitTasks_4BE0146918Row_0AT %I*SyncUnitTasks_4BE0146918Row_1AT %I*SyncUnitTasks_4BE0146918Row_2AT %I*SyncUnitTasks_4BE0146918Row_3AT %I*SyncUnitTasks_4BE0146918Row_4AT %I*SyncUnitTasks_4BE0146918";
			AttributeCRC = "2443455423";
			AttributeSize = "108";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSyncUnits_91A42BBF
	{
		public void CopyPlainToCyclic(Plc1.SyncUnits_91A42BBF target)
		{
			base.CopyPlainToCyclic(target);
			_default.CopyPlainToCyclic(target._default);
			Row_0.CopyPlainToCyclic(target.Row_0);
			Row_1.CopyPlainToCyclic(target.Row_1);
			Row_2.CopyPlainToCyclic(target.Row_2);
			Row_3.CopyPlainToCyclic(target.Row_3);
			Row_4.CopyPlainToCyclic(target.Row_4);
		}

		public void CopyPlainToCyclic(Plc1.ISyncUnits_91A42BBF target)
		{
			this.CopyPlainToCyclic((Plc1.SyncUnits_91A42BBF)target);
		}

		public void CopyPlainToShadow(Plc1.SyncUnits_91A42BBF target)
		{
			base.CopyPlainToShadow(target);
			_default.CopyPlainToShadow(target._default);
			Row_0.CopyPlainToShadow(target.Row_0);
			Row_1.CopyPlainToShadow(target.Row_1);
			Row_2.CopyPlainToShadow(target.Row_2);
			Row_3.CopyPlainToShadow(target.Row_3);
			Row_4.CopyPlainToShadow(target.Row_4);
		}

		public void CopyPlainToShadow(Plc1.IShadowSyncUnits_91A42BBF target)
		{
			this.CopyPlainToShadow((Plc1.SyncUnits_91A42BBF)target);
		}

		public void CopyCyclicToPlain(Plc1.SyncUnits_91A42BBF source)
		{
			base.CopyCyclicToPlain(source);
			_default.CopyCyclicToPlain(source._default);
			Row_0.CopyCyclicToPlain(source.Row_0);
			Row_1.CopyCyclicToPlain(source.Row_1);
			Row_2.CopyCyclicToPlain(source.Row_2);
			Row_3.CopyCyclicToPlain(source.Row_3);
			Row_4.CopyCyclicToPlain(source.Row_4);
		}

		public void CopyCyclicToPlain(Plc1.ISyncUnits_91A42BBF source)
		{
			this.CopyCyclicToPlain((Plc1.SyncUnits_91A42BBF)source);
		}

		public void CopyShadowToPlain(Plc1.SyncUnits_91A42BBF source)
		{
			base.CopyShadowToPlain(source);
			_default.CopyShadowToPlain(source._default);
			Row_0.CopyShadowToPlain(source.Row_0);
			Row_1.CopyShadowToPlain(source.Row_1);
			Row_2.CopyShadowToPlain(source.Row_2);
			Row_3.CopyShadowToPlain(source.Row_3);
			Row_4.CopyShadowToPlain(source.Row_4);
		}

		public void CopyShadowToPlain(Plc1.IShadowSyncUnits_91A42BBF source)
		{
			this.CopyShadowToPlain((Plc1.SyncUnits_91A42BBF)source);
		}
	}
}