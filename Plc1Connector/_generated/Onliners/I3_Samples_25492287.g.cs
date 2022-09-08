using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"ARRAY_0INT2ARRAY_1INT2ARRAY_2INT2ARRAY_3INT2ARRAY_4INT2ARRAY_5INT2ARRAY_6INT2ARRAY_7INT2ARRAY_8INT2ARRAY_9INT2\" } {attribute addProperty CRC \"625549959\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "I3_Samples_25492287", "Plc1", TypeComplexityEnum.Complex)]
	public partial class I3_Samples_25492287 : Vortex.Connector.IVortexObject, II3_Samples_25492287, IShadowI3_Samples_25492287, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_0;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_0
		{
			get
			{
				return _ARRAY_0;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_0
		{
			get
			{
				return ARRAY_0;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_0
		{
			get
			{
				return ARRAY_0;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_1;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_1
		{
			get
			{
				return _ARRAY_1;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_1
		{
			get
			{
				return ARRAY_1;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_1
		{
			get
			{
				return ARRAY_1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_2;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_2
		{
			get
			{
				return _ARRAY_2;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_2
		{
			get
			{
				return ARRAY_2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_2
		{
			get
			{
				return ARRAY_2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_3;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_3
		{
			get
			{
				return _ARRAY_3;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_3
		{
			get
			{
				return ARRAY_3;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_3
		{
			get
			{
				return ARRAY_3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_4;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_4
		{
			get
			{
				return _ARRAY_4;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_4
		{
			get
			{
				return ARRAY_4;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_4
		{
			get
			{
				return ARRAY_4;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_5;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_5
		{
			get
			{
				return _ARRAY_5;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_5
		{
			get
			{
				return ARRAY_5;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_5
		{
			get
			{
				return ARRAY_5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_6;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_6
		{
			get
			{
				return _ARRAY_6;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_6
		{
			get
			{
				return ARRAY_6;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_6
		{
			get
			{
				return ARRAY_6;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_7;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_7
		{
			get
			{
				return _ARRAY_7;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_7
		{
			get
			{
				return ARRAY_7;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_7
		{
			get
			{
				return ARRAY_7;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_8;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_8
		{
			get
			{
				return _ARRAY_8;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_8
		{
			get
			{
				return ARRAY_8;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_8
		{
			get
			{
				return ARRAY_8;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _ARRAY_9;
		public Vortex.Connector.ValueTypes.OnlinerInt ARRAY_9
		{
			get
			{
				return _ARRAY_9;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt II3_Samples_25492287.ARRAY_9
		{
			get
			{
				return ARRAY_9;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowI3_Samples_25492287.ARRAY_9
		{
			get
			{
				return ARRAY_9;
			}
		}

		public void LazyOnlineToShadow()
		{
			ARRAY_0.Shadow = ARRAY_0.LastValue;
			ARRAY_1.Shadow = ARRAY_1.LastValue;
			ARRAY_2.Shadow = ARRAY_2.LastValue;
			ARRAY_3.Shadow = ARRAY_3.LastValue;
			ARRAY_4.Shadow = ARRAY_4.LastValue;
			ARRAY_5.Shadow = ARRAY_5.LastValue;
			ARRAY_6.Shadow = ARRAY_6.LastValue;
			ARRAY_7.Shadow = ARRAY_7.LastValue;
			ARRAY_8.Shadow = ARRAY_8.LastValue;
			ARRAY_9.Shadow = ARRAY_9.LastValue;
		}

		public void LazyShadowToOnline()
		{
			ARRAY_0.Cyclic = ARRAY_0.Shadow;
			ARRAY_1.Cyclic = ARRAY_1.Shadow;
			ARRAY_2.Cyclic = ARRAY_2.Shadow;
			ARRAY_3.Cyclic = ARRAY_3.Shadow;
			ARRAY_4.Cyclic = ARRAY_4.Shadow;
			ARRAY_5.Cyclic = ARRAY_5.Shadow;
			ARRAY_6.Cyclic = ARRAY_6.Shadow;
			ARRAY_7.Cyclic = ARRAY_7.Shadow;
			ARRAY_8.Cyclic = ARRAY_8.Shadow;
			ARRAY_9.Cyclic = ARRAY_9.Shadow;
		}

		public PlainI3_Samples_25492287 CreatePlainerType()
		{
			var cloned = new PlainI3_Samples_25492287();
			return cloned;
		}

		protected PlainI3_Samples_25492287 CreatePlainerType(PlainI3_Samples_25492287 cloned)
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

		public void FlushPlainToOnline(Plc1.PlainI3_Samples_25492287 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainI3_Samples_25492287 source)
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

		public void FlushOnlineToPlain(Plc1.PlainI3_Samples_25492287 source)
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

		public I3_Samples_25492287(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_ARRAY_0 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_0", "ARRAY_0");
			ARRAY_0.AttributeName = "ARRAY_0";
			_ARRAY_1 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_1", "ARRAY_1");
			ARRAY_1.AttributeName = "ARRAY_1";
			_ARRAY_2 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_2", "ARRAY_2");
			ARRAY_2.AttributeName = "ARRAY_2";
			_ARRAY_3 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_3", "ARRAY_3");
			ARRAY_3.AttributeName = "ARRAY_3";
			_ARRAY_4 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_4", "ARRAY_4");
			ARRAY_4.AttributeName = "ARRAY_4";
			_ARRAY_5 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_5", "ARRAY_5");
			ARRAY_5.AttributeName = "ARRAY_5";
			_ARRAY_6 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_6", "ARRAY_6");
			ARRAY_6.AttributeName = "ARRAY_6";
			_ARRAY_7 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_7", "ARRAY_7");
			ARRAY_7.AttributeName = "ARRAY_7";
			_ARRAY_8 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_8", "ARRAY_8");
			ARRAY_8.AttributeName = "ARRAY_8";
			_ARRAY_9 = @Connector.Online.Adapter.CreateINT(this, "ARRAY_9", "ARRAY_9");
			ARRAY_9.AttributeName = "ARRAY_9";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "ARRAY_0INT2ARRAY_1INT2ARRAY_2INT2ARRAY_3INT2ARRAY_4INT2ARRAY_5INT2ARRAY_6INT2ARRAY_7INT2ARRAY_8INT2ARRAY_9INT2";
			AttributeCRC = "625549959";
			AttributeSize = "20";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public I3_Samples_25492287()
		{
			PexPreConstructorParameterless();
			_ARRAY_0 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_0.AttributeName = "ARRAY_0";
			_ARRAY_1 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_1.AttributeName = "ARRAY_1";
			_ARRAY_2 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_2.AttributeName = "ARRAY_2";
			_ARRAY_3 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_3.AttributeName = "ARRAY_3";
			_ARRAY_4 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_4.AttributeName = "ARRAY_4";
			_ARRAY_5 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_5.AttributeName = "ARRAY_5";
			_ARRAY_6 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_6.AttributeName = "ARRAY_6";
			_ARRAY_7 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_7.AttributeName = "ARRAY_7";
			_ARRAY_8 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_8.AttributeName = "ARRAY_8";
			_ARRAY_9 = Vortex.Connector.IConnectorFactory.CreateINT();
			ARRAY_9.AttributeName = "ARRAY_9";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "ARRAY_0INT2ARRAY_1INT2ARRAY_2INT2ARRAY_3INT2ARRAY_4INT2ARRAY_5INT2ARRAY_6INT2ARRAY_7INT2ARRAY_8INT2ARRAY_9INT2";
			AttributeCRC = "625549959";
			AttributeSize = "20";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainI3_Samples_25492287
	{
		public void CopyPlainToCyclic(Plc1.I3_Samples_25492287 target)
		{
			target.ARRAY_0.Cyclic = ARRAY_0;
			target.ARRAY_1.Cyclic = ARRAY_1;
			target.ARRAY_2.Cyclic = ARRAY_2;
			target.ARRAY_3.Cyclic = ARRAY_3;
			target.ARRAY_4.Cyclic = ARRAY_4;
			target.ARRAY_5.Cyclic = ARRAY_5;
			target.ARRAY_6.Cyclic = ARRAY_6;
			target.ARRAY_7.Cyclic = ARRAY_7;
			target.ARRAY_8.Cyclic = ARRAY_8;
			target.ARRAY_9.Cyclic = ARRAY_9;
		}

		public void CopyPlainToCyclic(Plc1.II3_Samples_25492287 target)
		{
			this.CopyPlainToCyclic((Plc1.I3_Samples_25492287)target);
		}

		public void CopyPlainToShadow(Plc1.I3_Samples_25492287 target)
		{
			target.ARRAY_0.Shadow = ARRAY_0;
			target.ARRAY_1.Shadow = ARRAY_1;
			target.ARRAY_2.Shadow = ARRAY_2;
			target.ARRAY_3.Shadow = ARRAY_3;
			target.ARRAY_4.Shadow = ARRAY_4;
			target.ARRAY_5.Shadow = ARRAY_5;
			target.ARRAY_6.Shadow = ARRAY_6;
			target.ARRAY_7.Shadow = ARRAY_7;
			target.ARRAY_8.Shadow = ARRAY_8;
			target.ARRAY_9.Shadow = ARRAY_9;
		}

		public void CopyPlainToShadow(Plc1.IShadowI3_Samples_25492287 target)
		{
			this.CopyPlainToShadow((Plc1.I3_Samples_25492287)target);
		}

		public void CopyCyclicToPlain(Plc1.I3_Samples_25492287 source)
		{
			ARRAY_0 = source.ARRAY_0.LastValue;
			ARRAY_1 = source.ARRAY_1.LastValue;
			ARRAY_2 = source.ARRAY_2.LastValue;
			ARRAY_3 = source.ARRAY_3.LastValue;
			ARRAY_4 = source.ARRAY_4.LastValue;
			ARRAY_5 = source.ARRAY_5.LastValue;
			ARRAY_6 = source.ARRAY_6.LastValue;
			ARRAY_7 = source.ARRAY_7.LastValue;
			ARRAY_8 = source.ARRAY_8.LastValue;
			ARRAY_9 = source.ARRAY_9.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.II3_Samples_25492287 source)
		{
			this.CopyCyclicToPlain((Plc1.I3_Samples_25492287)source);
		}

		public void CopyShadowToPlain(Plc1.I3_Samples_25492287 source)
		{
			ARRAY_0 = source.ARRAY_0.Shadow;
			ARRAY_1 = source.ARRAY_1.Shadow;
			ARRAY_2 = source.ARRAY_2.Shadow;
			ARRAY_3 = source.ARRAY_3.Shadow;
			ARRAY_4 = source.ARRAY_4.Shadow;
			ARRAY_5 = source.ARRAY_5.Shadow;
			ARRAY_6 = source.ARRAY_6.Shadow;
			ARRAY_7 = source.ARRAY_7.Shadow;
			ARRAY_8 = source.ARRAY_8.Shadow;
			ARRAY_9 = source.ARRAY_9.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowI3_Samples_25492287 source)
		{
			this.CopyShadowToPlain((Plc1.I3_Samples_25492287)source);
		}
	}
}