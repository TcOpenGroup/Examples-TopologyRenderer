using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL2258-0000-0017\" } {attribute addProperty Id \"Output_buffer_resetBOOL1Manual_output_stateBOOL1Force_orderBOOL1Enable_manual_operationBOOL1Output_order_counterUSINT1No_of_output_eventsUSINT1\" } {attribute addProperty CRC \"2001079251\" } {attribute addProperty Size \"6\" } {attribute addProperty Name \"\" }", "Ctrl_77460BD3", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Ctrl_77460BD3 : Vortex.Connector.IVortexObject, ICtrl_77460BD3, IShadowCtrl_77460BD3, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _Output_buffer_reset;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_buffer_reset
		{
			get
			{
				return _Output_buffer_reset;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_77460BD3.Output_buffer_reset
		{
			get
			{
				return Output_buffer_reset;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_77460BD3.Output_buffer_reset
		{
			get
			{
				return Output_buffer_reset;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Manual_output_state;
		public Vortex.Connector.ValueTypes.OnlinerBool Manual_output_state
		{
			get
			{
				return _Manual_output_state;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_77460BD3.Manual_output_state
		{
			get
			{
				return Manual_output_state;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_77460BD3.Manual_output_state
		{
			get
			{
				return Manual_output_state;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Force_order;
		public Vortex.Connector.ValueTypes.OnlinerBool Force_order
		{
			get
			{
				return _Force_order;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_77460BD3.Force_order
		{
			get
			{
				return Force_order;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_77460BD3.Force_order
		{
			get
			{
				return Force_order;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Enable_manual_operation;
		public Vortex.Connector.ValueTypes.OnlinerBool Enable_manual_operation
		{
			get
			{
				return _Enable_manual_operation;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_77460BD3.Enable_manual_operation
		{
			get
			{
				return Enable_manual_operation;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_77460BD3.Enable_manual_operation
		{
			get
			{
				return Enable_manual_operation;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Output_order_counter;
		public Vortex.Connector.ValueTypes.OnlinerUSInt Output_order_counter
		{
			get
			{
				return _Output_order_counter;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt ICtrl_77460BD3.Output_order_counter
		{
			get
			{
				return Output_order_counter;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowCtrl_77460BD3.Output_order_counter
		{
			get
			{
				return Output_order_counter;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _No_of_output_events;
		public Vortex.Connector.ValueTypes.OnlinerUSInt No_of_output_events
		{
			get
			{
				return _No_of_output_events;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt ICtrl_77460BD3.No_of_output_events
		{
			get
			{
				return No_of_output_events;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowCtrl_77460BD3.No_of_output_events
		{
			get
			{
				return No_of_output_events;
			}
		}

		public void LazyOnlineToShadow()
		{
			Output_buffer_reset.Shadow = Output_buffer_reset.LastValue;
			Manual_output_state.Shadow = Manual_output_state.LastValue;
			Force_order.Shadow = Force_order.LastValue;
			Enable_manual_operation.Shadow = Enable_manual_operation.LastValue;
			Output_order_counter.Shadow = Output_order_counter.LastValue;
			No_of_output_events.Shadow = No_of_output_events.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Output_buffer_reset.Cyclic = Output_buffer_reset.Shadow;
			Manual_output_state.Cyclic = Manual_output_state.Shadow;
			Force_order.Cyclic = Force_order.Shadow;
			Enable_manual_operation.Cyclic = Enable_manual_operation.Shadow;
			Output_order_counter.Cyclic = Output_order_counter.Shadow;
			No_of_output_events.Cyclic = No_of_output_events.Shadow;
		}

		public PlainCtrl_77460BD3 CreatePlainerType()
		{
			var cloned = new PlainCtrl_77460BD3();
			return cloned;
		}

		protected PlainCtrl_77460BD3 CreatePlainerType(PlainCtrl_77460BD3 cloned)
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

		public void FlushPlainToOnline(Plc1.PlainCtrl_77460BD3 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainCtrl_77460BD3 source)
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

		public void FlushOnlineToPlain(Plc1.PlainCtrl_77460BD3 source)
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

		public Ctrl_77460BD3(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Output_buffer_reset = @Connector.Online.Adapter.CreateBOOL(this, "Output_buffer_reset", "Output_buffer_reset");
			Output_buffer_reset.AttributeName = "Output_buffer_reset";
			_Manual_output_state = @Connector.Online.Adapter.CreateBOOL(this, "Manual_output_state", "Manual_output_state");
			Manual_output_state.AttributeName = "Manual_output_state";
			_Force_order = @Connector.Online.Adapter.CreateBOOL(this, "Force_order", "Force_order");
			Force_order.AttributeName = "Force_order";
			_Enable_manual_operation = @Connector.Online.Adapter.CreateBOOL(this, "Enable_manual_operation", "Enable_manual_operation");
			Enable_manual_operation.AttributeName = "Enable_manual_operation";
			_Output_order_counter = @Connector.Online.Adapter.CreateUSINT(this, "Output_order_counter", "Output_order_counter");
			Output_order_counter.AttributeName = "Output_order_counter";
			_No_of_output_events = @Connector.Online.Adapter.CreateUSINT(this, "No_of_output_events", "No_of_output_events");
			No_of_output_events.AttributeName = "No_of_output_events";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "Output_buffer_resetBOOL1Manual_output_stateBOOL1Force_orderBOOL1Enable_manual_operationBOOL1Output_order_counterUSINT1No_of_output_eventsUSINT1";
			AttributeCRC = "2001079251";
			AttributeSize = "6";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Ctrl_77460BD3()
		{
			PexPreConstructorParameterless();
			_Output_buffer_reset = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_buffer_reset.AttributeName = "Output_buffer_reset";
			_Manual_output_state = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Manual_output_state.AttributeName = "Manual_output_state";
			_Force_order = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Force_order.AttributeName = "Force_order";
			_Enable_manual_operation = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Enable_manual_operation.AttributeName = "Enable_manual_operation";
			_Output_order_counter = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Output_order_counter.AttributeName = "Output_order_counter";
			_No_of_output_events = Vortex.Connector.IConnectorFactory.CreateUSINT();
			No_of_output_events.AttributeName = "No_of_output_events";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "Output_buffer_resetBOOL1Manual_output_stateBOOL1Force_orderBOOL1Enable_manual_operationBOOL1Output_order_counterUSINT1No_of_output_eventsUSINT1";
			AttributeCRC = "2001079251";
			AttributeSize = "6";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCtrl_77460BD3
	{
		public void CopyPlainToCyclic(Plc1.Ctrl_77460BD3 target)
		{
			target.Output_buffer_reset.Cyclic = Output_buffer_reset;
			target.Manual_output_state.Cyclic = Manual_output_state;
			target.Force_order.Cyclic = Force_order;
			target.Enable_manual_operation.Cyclic = Enable_manual_operation;
			target.Output_order_counter.Cyclic = Output_order_counter;
			target.No_of_output_events.Cyclic = No_of_output_events;
		}

		public void CopyPlainToCyclic(Plc1.ICtrl_77460BD3 target)
		{
			this.CopyPlainToCyclic((Plc1.Ctrl_77460BD3)target);
		}

		public void CopyPlainToShadow(Plc1.Ctrl_77460BD3 target)
		{
			target.Output_buffer_reset.Shadow = Output_buffer_reset;
			target.Manual_output_state.Shadow = Manual_output_state;
			target.Force_order.Shadow = Force_order;
			target.Enable_manual_operation.Shadow = Enable_manual_operation;
			target.Output_order_counter.Shadow = Output_order_counter;
			target.No_of_output_events.Shadow = No_of_output_events;
		}

		public void CopyPlainToShadow(Plc1.IShadowCtrl_77460BD3 target)
		{
			this.CopyPlainToShadow((Plc1.Ctrl_77460BD3)target);
		}

		public void CopyCyclicToPlain(Plc1.Ctrl_77460BD3 source)
		{
			Output_buffer_reset = source.Output_buffer_reset.LastValue;
			Manual_output_state = source.Manual_output_state.LastValue;
			Force_order = source.Force_order.LastValue;
			Enable_manual_operation = source.Enable_manual_operation.LastValue;
			Output_order_counter = source.Output_order_counter.LastValue;
			No_of_output_events = source.No_of_output_events.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.ICtrl_77460BD3 source)
		{
			this.CopyCyclicToPlain((Plc1.Ctrl_77460BD3)source);
		}

		public void CopyShadowToPlain(Plc1.Ctrl_77460BD3 source)
		{
			Output_buffer_reset = source.Output_buffer_reset.Shadow;
			Manual_output_state = source.Manual_output_state.Shadow;
			Force_order = source.Force_order.Shadow;
			Enable_manual_operation = source.Enable_manual_operation.Shadow;
			Output_order_counter = source.Output_order_counter.Shadow;
			No_of_output_events = source.No_of_output_events.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowCtrl_77460BD3 source)
		{
			this.CopyShadowToPlain((Plc1.Ctrl_77460BD3)source);
		}
	}
}