using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"LowUDINT4HiUDINT4\" } {attribute addProperty CRC \"48284104\" } {attribute addProperty Size \"8\" } {attribute addProperty Name \"\" }", "StartTimeNextLatch_02E0C1C8", "Plc1", TypeComplexityEnum.Complex)]
	public partial class StartTimeNextLatch_02E0C1C8 : Vortex.Connector.IVortexObject, IStartTimeNextLatch_02E0C1C8, IShadowStartTimeNextLatch_02E0C1C8, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerUDInt _Low;
		public Vortex.Connector.ValueTypes.OnlinerUDInt Low
		{
			get
			{
				return _Low;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IStartTimeNextLatch_02E0C1C8.Low
		{
			get
			{
				return Low;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowStartTimeNextLatch_02E0C1C8.Low
		{
			get
			{
				return Low;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _Hi;
		public Vortex.Connector.ValueTypes.OnlinerUDInt Hi
		{
			get
			{
				return _Hi;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IStartTimeNextLatch_02E0C1C8.Hi
		{
			get
			{
				return Hi;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowStartTimeNextLatch_02E0C1C8.Hi
		{
			get
			{
				return Hi;
			}
		}

		public void LazyOnlineToShadow()
		{
			Low.Shadow = Low.LastValue;
			Hi.Shadow = Hi.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Low.Cyclic = Low.Shadow;
			Hi.Cyclic = Hi.Shadow;
		}

		public PlainStartTimeNextLatch_02E0C1C8 CreatePlainerType()
		{
			var cloned = new PlainStartTimeNextLatch_02E0C1C8();
			return cloned;
		}

		protected PlainStartTimeNextLatch_02E0C1C8 CreatePlainerType(PlainStartTimeNextLatch_02E0C1C8 cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc1.PlainStartTimeNextLatch_02E0C1C8 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainStartTimeNextLatch_02E0C1C8 source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc1.PlainStartTimeNextLatch_02E0C1C8 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
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

		public System.String AttributeName
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeName, this).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public StartTimeNextLatch_02E0C1C8(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Low = @Connector.Online.Adapter.CreateUDINT(this, "Low", "Low");
			Low.AttributeName = "Low";
			_Hi = @Connector.Online.Adapter.CreateUDINT(this, "Hi", "Hi");
			Hi.AttributeName = "Hi";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "LowUDINT4HiUDINT4";
			AttributeCRC = "48284104";
			AttributeSize = "8";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public StartTimeNextLatch_02E0C1C8()
		{
			PexPreConstructorParameterless();
			_Low = Vortex.Connector.IConnectorFactory.CreateUDINT();
			Low.AttributeName = "Low";
			_Hi = Vortex.Connector.IConnectorFactory.CreateUDINT();
			Hi.AttributeName = "Hi";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "LowUDINT4HiUDINT4";
			AttributeCRC = "48284104";
			AttributeSize = "8";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStartTimeNextLatch_02E0C1C8
	{
		public void CopyPlainToCyclic(Plc1.StartTimeNextLatch_02E0C1C8 target)
		{
			target.Low.Cyclic = Low;
			target.Hi.Cyclic = Hi;
		}

		public void CopyPlainToCyclic(Plc1.IStartTimeNextLatch_02E0C1C8 target)
		{
			this.CopyPlainToCyclic((Plc1.StartTimeNextLatch_02E0C1C8)target);
		}

		public void CopyPlainToShadow(Plc1.StartTimeNextLatch_02E0C1C8 target)
		{
			target.Low.Shadow = Low;
			target.Hi.Shadow = Hi;
		}

		public void CopyPlainToShadow(Plc1.IShadowStartTimeNextLatch_02E0C1C8 target)
		{
			this.CopyPlainToShadow((Plc1.StartTimeNextLatch_02E0C1C8)target);
		}

		public void CopyCyclicToPlain(Plc1.StartTimeNextLatch_02E0C1C8 source)
		{
			Low = source.Low.LastValue;
			Hi = source.Hi.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IStartTimeNextLatch_02E0C1C8 source)
		{
			this.CopyCyclicToPlain((Plc1.StartTimeNextLatch_02E0C1C8)source);
		}

		public void CopyShadowToPlain(Plc1.StartTimeNextLatch_02E0C1C8 source)
		{
			Low = source.Low.Shadow;
			Hi = source.Hi.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowStartTimeNextLatch_02E0C1C8 source)
		{
			this.CopyShadowToPlain((Plc1.StartTimeNextLatch_02E0C1C8)source);
		}
	}
}