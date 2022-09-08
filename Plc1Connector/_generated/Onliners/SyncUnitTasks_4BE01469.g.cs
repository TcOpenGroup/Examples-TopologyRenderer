using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"\" } {attribute addProperty Id \"unreferencedAT %I*SyncUnitTask_AB2F50799PlcTaskAT %I*SyncUnitTask_AB2F50799\" } {attribute addProperty CRC \"1272976489\" } {attribute addProperty Size \"18\" } {attribute addProperty Name \"\" }", "SyncUnitTasks_4BE01469", "Plc1", TypeComplexityEnum.Complex)]
	public partial class SyncUnitTasks_4BE01469 : TcoIo.SyncUnitTasksBase_7C8711EB, Vortex.Connector.IVortexObject, ISyncUnitTasks_4BE01469, IShadowSyncUnitTasks_4BE01469, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		TcoIo.SyncUnitTask_AB2F5079 _unreferenced;
		public TcoIo.SyncUnitTask_AB2F5079 unreferenced
		{
			get
			{
				return _unreferenced;
			}
		}

		TcoIo.ISyncUnitTask_AB2F5079 ISyncUnitTasks_4BE01469.unreferenced
		{
			get
			{
				return unreferenced;
			}
		}

		TcoIo.IShadowSyncUnitTask_AB2F5079 IShadowSyncUnitTasks_4BE01469.unreferenced
		{
			get
			{
				return unreferenced;
			}
		}

		TcoIo.SyncUnitTask_AB2F5079 _PlcTask;
		public TcoIo.SyncUnitTask_AB2F5079 PlcTask
		{
			get
			{
				return _PlcTask;
			}
		}

		TcoIo.ISyncUnitTask_AB2F5079 ISyncUnitTasks_4BE01469.PlcTask
		{
			get
			{
				return PlcTask;
			}
		}

		TcoIo.IShadowSyncUnitTask_AB2F5079 IShadowSyncUnitTasks_4BE01469.PlcTask
		{
			get
			{
				return PlcTask;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			unreferenced.LazyOnlineToShadow();
			PlcTask.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			unreferenced.LazyShadowToOnline();
			PlcTask.LazyShadowToOnline();
		}

		public new PlainSyncUnitTasks_4BE01469 CreatePlainerType()
		{
			var cloned = new PlainSyncUnitTasks_4BE01469();
			base.CreatePlainerType(cloned);
			cloned.unreferenced = unreferenced.CreatePlainerType();
			cloned.PlcTask = PlcTask.CreatePlainerType();
			return cloned;
		}

		protected PlainSyncUnitTasks_4BE01469 CreatePlainerType(PlainSyncUnitTasks_4BE01469 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.unreferenced = unreferenced.CreatePlainerType();
			cloned.PlcTask = PlcTask.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainSyncUnitTasks_4BE01469 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainSyncUnitTasks_4BE01469 source)
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

		public void FlushOnlineToPlain(Plc1.PlainSyncUnitTasks_4BE01469 source)
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

		public SyncUnitTasks_4BE01469(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_unreferenced = new TcoIo.SyncUnitTask_AB2F5079(this, "unreferenced", "unreferenced");
			_unreferenced.AttributeName = "unreferenced";
			_PlcTask = new TcoIo.SyncUnitTask_AB2F5079(this, "PlcTask", "PlcTask");
			_PlcTask.AttributeName = "PlcTask";
			AttributeBoxType = "";
			AttributeId = "unreferencedAT %I*SyncUnitTask_AB2F50799PlcTaskAT %I*SyncUnitTask_AB2F50799";
			AttributeCRC = "1272976489";
			AttributeSize = "18";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public SyncUnitTasks_4BE01469(): base ()
		{
			PexPreConstructorParameterless();
			_unreferenced = new TcoIo.SyncUnitTask_AB2F5079();
			_unreferenced.AttributeName = "unreferenced";
			_PlcTask = new TcoIo.SyncUnitTask_AB2F5079();
			_PlcTask.AttributeName = "PlcTask";
			AttributeBoxType = "";
			AttributeId = "unreferencedAT %I*SyncUnitTask_AB2F50799PlcTaskAT %I*SyncUnitTask_AB2F50799";
			AttributeCRC = "1272976489";
			AttributeSize = "18";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainSyncUnitTasks_4BE01469
	{
		public void CopyPlainToCyclic(Plc1.SyncUnitTasks_4BE01469 target)
		{
			base.CopyPlainToCyclic(target);
			unreferenced.CopyPlainToCyclic(target.unreferenced);
			PlcTask.CopyPlainToCyclic(target.PlcTask);
		}

		public void CopyPlainToCyclic(Plc1.ISyncUnitTasks_4BE01469 target)
		{
			this.CopyPlainToCyclic((Plc1.SyncUnitTasks_4BE01469)target);
		}

		public void CopyPlainToShadow(Plc1.SyncUnitTasks_4BE01469 target)
		{
			base.CopyPlainToShadow(target);
			unreferenced.CopyPlainToShadow(target.unreferenced);
			PlcTask.CopyPlainToShadow(target.PlcTask);
		}

		public void CopyPlainToShadow(Plc1.IShadowSyncUnitTasks_4BE01469 target)
		{
			this.CopyPlainToShadow((Plc1.SyncUnitTasks_4BE01469)target);
		}

		public void CopyCyclicToPlain(Plc1.SyncUnitTasks_4BE01469 source)
		{
			base.CopyCyclicToPlain(source);
			unreferenced.CopyCyclicToPlain(source.unreferenced);
			PlcTask.CopyCyclicToPlain(source.PlcTask);
		}

		public void CopyCyclicToPlain(Plc1.ISyncUnitTasks_4BE01469 source)
		{
			this.CopyCyclicToPlain((Plc1.SyncUnitTasks_4BE01469)source);
		}

		public void CopyShadowToPlain(Plc1.SyncUnitTasks_4BE01469 source)
		{
			base.CopyShadowToPlain(source);
			unreferenced.CopyShadowToPlain(source.unreferenced);
			PlcTask.CopyShadowToPlain(source.PlcTask);
		}

		public void CopyShadowToPlain(Plc1.IShadowSyncUnitTasks_4BE01469 source)
		{
			this.CopyShadowToPlain((Plc1.SyncUnitTasks_4BE01469)source);
		}
	}
}