using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL2258-0000-0017\" } {attribute addProperty Id \"Output_event_state_1BOOL1Output_event_state_2BOOL1Output_event_state_3BOOL1Output_event_state_4BOOL1Output_event_state_5BOOL1Output_event_state_6BOOL1Output_event_state_7BOOL1Output_event_state_8BOOL1Output_event_state_9BOOL1Output_event_state_10BOOL1\" } {attribute addProperty CRC \"2836416589\" } {attribute addProperty Size \"10\" } {attribute addProperty Name \"\" }", "Outputs_A910484D", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Outputs_A910484D : Vortex.Connector.IVortexObject, IOutputs_A910484D, IShadowOutputs_A910484D, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_1;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_1
		{
			get
			{
				return _Output_event_state_1;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_1
		{
			get
			{
				return Output_event_state_1;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_1
		{
			get
			{
				return Output_event_state_1;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_2;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_2
		{
			get
			{
				return _Output_event_state_2;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_2
		{
			get
			{
				return Output_event_state_2;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_2
		{
			get
			{
				return Output_event_state_2;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_3;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_3
		{
			get
			{
				return _Output_event_state_3;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_3
		{
			get
			{
				return Output_event_state_3;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_3
		{
			get
			{
				return Output_event_state_3;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_4;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_4
		{
			get
			{
				return _Output_event_state_4;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_4
		{
			get
			{
				return Output_event_state_4;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_4
		{
			get
			{
				return Output_event_state_4;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_5;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_5
		{
			get
			{
				return _Output_event_state_5;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_5
		{
			get
			{
				return Output_event_state_5;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_5
		{
			get
			{
				return Output_event_state_5;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_6;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_6
		{
			get
			{
				return _Output_event_state_6;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_6
		{
			get
			{
				return Output_event_state_6;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_6
		{
			get
			{
				return Output_event_state_6;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_7;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_7
		{
			get
			{
				return _Output_event_state_7;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_7
		{
			get
			{
				return Output_event_state_7;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_7
		{
			get
			{
				return Output_event_state_7;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_8;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_8
		{
			get
			{
				return _Output_event_state_8;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_8
		{
			get
			{
				return Output_event_state_8;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_8
		{
			get
			{
				return Output_event_state_8;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_9;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_9
		{
			get
			{
				return _Output_event_state_9;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_9
		{
			get
			{
				return Output_event_state_9;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_9
		{
			get
			{
				return Output_event_state_9;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_event_state_10;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_event_state_10
		{
			get
			{
				return _Output_event_state_10;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IOutputs_A910484D.Output_event_state_10
		{
			get
			{
				return Output_event_state_10;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowOutputs_A910484D.Output_event_state_10
		{
			get
			{
				return Output_event_state_10;
			}
		}

		public void LazyOnlineToShadow()
		{
			Output_event_state_1.Shadow = Output_event_state_1.LastValue;
			Output_event_state_2.Shadow = Output_event_state_2.LastValue;
			Output_event_state_3.Shadow = Output_event_state_3.LastValue;
			Output_event_state_4.Shadow = Output_event_state_4.LastValue;
			Output_event_state_5.Shadow = Output_event_state_5.LastValue;
			Output_event_state_6.Shadow = Output_event_state_6.LastValue;
			Output_event_state_7.Shadow = Output_event_state_7.LastValue;
			Output_event_state_8.Shadow = Output_event_state_8.LastValue;
			Output_event_state_9.Shadow = Output_event_state_9.LastValue;
			Output_event_state_10.Shadow = Output_event_state_10.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Output_event_state_1.Cyclic = Output_event_state_1.Shadow;
			Output_event_state_2.Cyclic = Output_event_state_2.Shadow;
			Output_event_state_3.Cyclic = Output_event_state_3.Shadow;
			Output_event_state_4.Cyclic = Output_event_state_4.Shadow;
			Output_event_state_5.Cyclic = Output_event_state_5.Shadow;
			Output_event_state_6.Cyclic = Output_event_state_6.Shadow;
			Output_event_state_7.Cyclic = Output_event_state_7.Shadow;
			Output_event_state_8.Cyclic = Output_event_state_8.Shadow;
			Output_event_state_9.Cyclic = Output_event_state_9.Shadow;
			Output_event_state_10.Cyclic = Output_event_state_10.Shadow;
		}

		public PlainOutputs_A910484D CreatePlainerType()
		{
			var cloned = new PlainOutputs_A910484D();
			return cloned;
		}

		protected PlainOutputs_A910484D CreatePlainerType(PlainOutputs_A910484D cloned)
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

		public void FlushPlainToOnline(Plc1.PlainOutputs_A910484D source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainOutputs_A910484D source)
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

		public void FlushOnlineToPlain(Plc1.PlainOutputs_A910484D source)
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

		public Outputs_A910484D(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Output_event_state_1 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_1", "Output_event_state_1");
			Output_event_state_1.AttributeName = "Output_event_state_1";
			_Output_event_state_2 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_2", "Output_event_state_2");
			Output_event_state_2.AttributeName = "Output_event_state_2";
			_Output_event_state_3 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_3", "Output_event_state_3");
			Output_event_state_3.AttributeName = "Output_event_state_3";
			_Output_event_state_4 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_4", "Output_event_state_4");
			Output_event_state_4.AttributeName = "Output_event_state_4";
			_Output_event_state_5 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_5", "Output_event_state_5");
			Output_event_state_5.AttributeName = "Output_event_state_5";
			_Output_event_state_6 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_6", "Output_event_state_6");
			Output_event_state_6.AttributeName = "Output_event_state_6";
			_Output_event_state_7 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_7", "Output_event_state_7");
			Output_event_state_7.AttributeName = "Output_event_state_7";
			_Output_event_state_8 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_8", "Output_event_state_8");
			Output_event_state_8.AttributeName = "Output_event_state_8";
			_Output_event_state_9 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_9", "Output_event_state_9");
			Output_event_state_9.AttributeName = "Output_event_state_9";
			_Output_event_state_10 = @Connector.Online.Adapter.CreateBOOL(this, "Output_event_state_10", "Output_event_state_10");
			Output_event_state_10.AttributeName = "Output_event_state_10";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "Output_event_state_1BOOL1Output_event_state_2BOOL1Output_event_state_3BOOL1Output_event_state_4BOOL1Output_event_state_5BOOL1Output_event_state_6BOOL1Output_event_state_7BOOL1Output_event_state_8BOOL1Output_event_state_9BOOL1Output_event_state_10BOOL1";
			AttributeCRC = "2836416589";
			AttributeSize = "10";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Outputs_A910484D()
		{
			PexPreConstructorParameterless();
			_Output_event_state_1 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_1.AttributeName = "Output_event_state_1";
			_Output_event_state_2 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_2.AttributeName = "Output_event_state_2";
			_Output_event_state_3 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_3.AttributeName = "Output_event_state_3";
			_Output_event_state_4 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_4.AttributeName = "Output_event_state_4";
			_Output_event_state_5 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_5.AttributeName = "Output_event_state_5";
			_Output_event_state_6 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_6.AttributeName = "Output_event_state_6";
			_Output_event_state_7 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_7.AttributeName = "Output_event_state_7";
			_Output_event_state_8 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_8.AttributeName = "Output_event_state_8";
			_Output_event_state_9 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_9.AttributeName = "Output_event_state_9";
			_Output_event_state_10 = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_event_state_10.AttributeName = "Output_event_state_10";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "Output_event_state_1BOOL1Output_event_state_2BOOL1Output_event_state_3BOOL1Output_event_state_4BOOL1Output_event_state_5BOOL1Output_event_state_6BOOL1Output_event_state_7BOOL1Output_event_state_8BOOL1Output_event_state_9BOOL1Output_event_state_10BOOL1";
			AttributeCRC = "2836416589";
			AttributeSize = "10";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainOutputs_A910484D
	{
		public void CopyPlainToCyclic(Plc1.Outputs_A910484D target)
		{
			target.Output_event_state_1.Cyclic = Output_event_state_1;
			target.Output_event_state_2.Cyclic = Output_event_state_2;
			target.Output_event_state_3.Cyclic = Output_event_state_3;
			target.Output_event_state_4.Cyclic = Output_event_state_4;
			target.Output_event_state_5.Cyclic = Output_event_state_5;
			target.Output_event_state_6.Cyclic = Output_event_state_6;
			target.Output_event_state_7.Cyclic = Output_event_state_7;
			target.Output_event_state_8.Cyclic = Output_event_state_8;
			target.Output_event_state_9.Cyclic = Output_event_state_9;
			target.Output_event_state_10.Cyclic = Output_event_state_10;
		}

		public void CopyPlainToCyclic(Plc1.IOutputs_A910484D target)
		{
			this.CopyPlainToCyclic((Plc1.Outputs_A910484D)target);
		}

		public void CopyPlainToShadow(Plc1.Outputs_A910484D target)
		{
			target.Output_event_state_1.Shadow = Output_event_state_1;
			target.Output_event_state_2.Shadow = Output_event_state_2;
			target.Output_event_state_3.Shadow = Output_event_state_3;
			target.Output_event_state_4.Shadow = Output_event_state_4;
			target.Output_event_state_5.Shadow = Output_event_state_5;
			target.Output_event_state_6.Shadow = Output_event_state_6;
			target.Output_event_state_7.Shadow = Output_event_state_7;
			target.Output_event_state_8.Shadow = Output_event_state_8;
			target.Output_event_state_9.Shadow = Output_event_state_9;
			target.Output_event_state_10.Shadow = Output_event_state_10;
		}

		public void CopyPlainToShadow(Plc1.IShadowOutputs_A910484D target)
		{
			this.CopyPlainToShadow((Plc1.Outputs_A910484D)target);
		}

		public void CopyCyclicToPlain(Plc1.Outputs_A910484D source)
		{
			Output_event_state_1 = source.Output_event_state_1.LastValue;
			Output_event_state_2 = source.Output_event_state_2.LastValue;
			Output_event_state_3 = source.Output_event_state_3.LastValue;
			Output_event_state_4 = source.Output_event_state_4.LastValue;
			Output_event_state_5 = source.Output_event_state_5.LastValue;
			Output_event_state_6 = source.Output_event_state_6.LastValue;
			Output_event_state_7 = source.Output_event_state_7.LastValue;
			Output_event_state_8 = source.Output_event_state_8.LastValue;
			Output_event_state_9 = source.Output_event_state_9.LastValue;
			Output_event_state_10 = source.Output_event_state_10.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IOutputs_A910484D source)
		{
			this.CopyCyclicToPlain((Plc1.Outputs_A910484D)source);
		}

		public void CopyShadowToPlain(Plc1.Outputs_A910484D source)
		{
			Output_event_state_1 = source.Output_event_state_1.Shadow;
			Output_event_state_2 = source.Output_event_state_2.Shadow;
			Output_event_state_3 = source.Output_event_state_3.Shadow;
			Output_event_state_4 = source.Output_event_state_4.Shadow;
			Output_event_state_5 = source.Output_event_state_5.Shadow;
			Output_event_state_6 = source.Output_event_state_6.Shadow;
			Output_event_state_7 = source.Output_event_state_7.Shadow;
			Output_event_state_8 = source.Output_event_state_8.Shadow;
			Output_event_state_9 = source.Output_event_state_9.Shadow;
			Output_event_state_10 = source.Output_event_state_10.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowOutputs_A910484D source)
		{
			this.CopyShadowToPlain((Plc1.Outputs_A910484D)source);
		}
	}
}