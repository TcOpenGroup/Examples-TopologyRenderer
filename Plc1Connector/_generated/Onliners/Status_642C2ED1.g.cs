using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL2258-0000-0017\" } {attribute addProperty Id \"Output_short_circuitBOOL1Output_buffer_overflowBOOL1Output_stateBOOL1Input_cycle_counterBYTE1Output_order_feedbackUSINT1Events_in_output_bufferUSINT1\" } {attribute addProperty CRC \"1680617169\" } {attribute addProperty Size \"6\" } {attribute addProperty Name \"\" }", "Status_642C2ED1", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Status_642C2ED1 : Vortex.Connector.IVortexObject, IStatus_642C2ED1, IShadowStatus_642C2ED1, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _Output_short_circuit;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_short_circuit
		{
			get
			{
				return _Output_short_circuit;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_642C2ED1.Output_short_circuit
		{
			get
			{
				return Output_short_circuit;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_642C2ED1.Output_short_circuit
		{
			get
			{
				return Output_short_circuit;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_buffer_overflow;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_buffer_overflow
		{
			get
			{
				return _Output_buffer_overflow;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_642C2ED1.Output_buffer_overflow
		{
			get
			{
				return Output_buffer_overflow;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_642C2ED1.Output_buffer_overflow
		{
			get
			{
				return Output_buffer_overflow;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Output_state;
		public Vortex.Connector.ValueTypes.OnlinerBool Output_state
		{
			get
			{
				return _Output_state;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_642C2ED1.Output_state
		{
			get
			{
				return Output_state;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_642C2ED1.Output_state
		{
			get
			{
				return Output_state;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _Input_cycle_counter;
		public Vortex.Connector.ValueTypes.OnlinerByte Input_cycle_counter
		{
			get
			{
				return _Input_cycle_counter;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte IStatus_642C2ED1.Input_cycle_counter
		{
			get
			{
				return Input_cycle_counter;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowStatus_642C2ED1.Input_cycle_counter
		{
			get
			{
				return Input_cycle_counter;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Output_order_feedback;
		public Vortex.Connector.ValueTypes.OnlinerUSInt Output_order_feedback
		{
			get
			{
				return _Output_order_feedback;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IStatus_642C2ED1.Output_order_feedback
		{
			get
			{
				return Output_order_feedback;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowStatus_642C2ED1.Output_order_feedback
		{
			get
			{
				return Output_order_feedback;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Events_in_output_buffer;
		public Vortex.Connector.ValueTypes.OnlinerUSInt Events_in_output_buffer
		{
			get
			{
				return _Events_in_output_buffer;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IStatus_642C2ED1.Events_in_output_buffer
		{
			get
			{
				return Events_in_output_buffer;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowStatus_642C2ED1.Events_in_output_buffer
		{
			get
			{
				return Events_in_output_buffer;
			}
		}

		public void LazyOnlineToShadow()
		{
			Output_short_circuit.Shadow = Output_short_circuit.LastValue;
			Output_buffer_overflow.Shadow = Output_buffer_overflow.LastValue;
			Output_state.Shadow = Output_state.LastValue;
			Input_cycle_counter.Shadow = Input_cycle_counter.LastValue;
			Output_order_feedback.Shadow = Output_order_feedback.LastValue;
			Events_in_output_buffer.Shadow = Events_in_output_buffer.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Output_short_circuit.Cyclic = Output_short_circuit.Shadow;
			Output_buffer_overflow.Cyclic = Output_buffer_overflow.Shadow;
			Output_state.Cyclic = Output_state.Shadow;
			Input_cycle_counter.Cyclic = Input_cycle_counter.Shadow;
			Output_order_feedback.Cyclic = Output_order_feedback.Shadow;
			Events_in_output_buffer.Cyclic = Events_in_output_buffer.Shadow;
		}

		public PlainStatus_642C2ED1 CreatePlainerType()
		{
			var cloned = new PlainStatus_642C2ED1();
			return cloned;
		}

		protected PlainStatus_642C2ED1 CreatePlainerType(PlainStatus_642C2ED1 cloned)
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

		public void FlushPlainToOnline(Plc1.PlainStatus_642C2ED1 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainStatus_642C2ED1 source)
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

		public void FlushOnlineToPlain(Plc1.PlainStatus_642C2ED1 source)
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

		public Status_642C2ED1(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Output_short_circuit = @Connector.Online.Adapter.CreateBOOL(this, "Output_short_circuit", "Output_short_circuit");
			Output_short_circuit.AttributeName = "Output_short_circuit";
			_Output_buffer_overflow = @Connector.Online.Adapter.CreateBOOL(this, "Output_buffer_overflow", "Output_buffer_overflow");
			Output_buffer_overflow.AttributeName = "Output_buffer_overflow";
			_Output_state = @Connector.Online.Adapter.CreateBOOL(this, "Output_state", "Output_state");
			Output_state.AttributeName = "Output_state";
			_Input_cycle_counter = @Connector.Online.Adapter.CreateBYTE(this, "Input_cycle_counter", "Input_cycle_counter");
			Input_cycle_counter.AttributeName = "Input_cycle_counter";
			_Output_order_feedback = @Connector.Online.Adapter.CreateUSINT(this, "Output_order_feedback", "Output_order_feedback");
			Output_order_feedback.AttributeName = "Output_order_feedback";
			_Events_in_output_buffer = @Connector.Online.Adapter.CreateUSINT(this, "Events_in_output_buffer", "Events_in_output_buffer");
			Events_in_output_buffer.AttributeName = "Events_in_output_buffer";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "Output_short_circuitBOOL1Output_buffer_overflowBOOL1Output_stateBOOL1Input_cycle_counterBYTE1Output_order_feedbackUSINT1Events_in_output_bufferUSINT1";
			AttributeCRC = "1680617169";
			AttributeSize = "6";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Status_642C2ED1()
		{
			PexPreConstructorParameterless();
			_Output_short_circuit = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_short_circuit.AttributeName = "Output_short_circuit";
			_Output_buffer_overflow = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_buffer_overflow.AttributeName = "Output_buffer_overflow";
			_Output_state = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output_state.AttributeName = "Output_state";
			_Input_cycle_counter = Vortex.Connector.IConnectorFactory.CreateBYTE();
			Input_cycle_counter.AttributeName = "Input_cycle_counter";
			_Output_order_feedback = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Output_order_feedback.AttributeName = "Output_order_feedback";
			_Events_in_output_buffer = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Events_in_output_buffer.AttributeName = "Events_in_output_buffer";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "Output_short_circuitBOOL1Output_buffer_overflowBOOL1Output_stateBOOL1Input_cycle_counterBYTE1Output_order_feedbackUSINT1Events_in_output_bufferUSINT1";
			AttributeCRC = "1680617169";
			AttributeSize = "6";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStatus_642C2ED1
	{
		public void CopyPlainToCyclic(Plc1.Status_642C2ED1 target)
		{
			target.Output_short_circuit.Cyclic = Output_short_circuit;
			target.Output_buffer_overflow.Cyclic = Output_buffer_overflow;
			target.Output_state.Cyclic = Output_state;
			target.Input_cycle_counter.Cyclic = Input_cycle_counter;
			target.Output_order_feedback.Cyclic = Output_order_feedback;
			target.Events_in_output_buffer.Cyclic = Events_in_output_buffer;
		}

		public void CopyPlainToCyclic(Plc1.IStatus_642C2ED1 target)
		{
			this.CopyPlainToCyclic((Plc1.Status_642C2ED1)target);
		}

		public void CopyPlainToShadow(Plc1.Status_642C2ED1 target)
		{
			target.Output_short_circuit.Shadow = Output_short_circuit;
			target.Output_buffer_overflow.Shadow = Output_buffer_overflow;
			target.Output_state.Shadow = Output_state;
			target.Input_cycle_counter.Shadow = Input_cycle_counter;
			target.Output_order_feedback.Shadow = Output_order_feedback;
			target.Events_in_output_buffer.Shadow = Events_in_output_buffer;
		}

		public void CopyPlainToShadow(Plc1.IShadowStatus_642C2ED1 target)
		{
			this.CopyPlainToShadow((Plc1.Status_642C2ED1)target);
		}

		public void CopyCyclicToPlain(Plc1.Status_642C2ED1 source)
		{
			Output_short_circuit = source.Output_short_circuit.LastValue;
			Output_buffer_overflow = source.Output_buffer_overflow.LastValue;
			Output_state = source.Output_state.LastValue;
			Input_cycle_counter = source.Input_cycle_counter.LastValue;
			Output_order_feedback = source.Output_order_feedback.LastValue;
			Events_in_output_buffer = source.Events_in_output_buffer.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IStatus_642C2ED1 source)
		{
			this.CopyCyclicToPlain((Plc1.Status_642C2ED1)source);
		}

		public void CopyShadowToPlain(Plc1.Status_642C2ED1 source)
		{
			Output_short_circuit = source.Output_short_circuit.Shadow;
			Output_buffer_overflow = source.Output_buffer_overflow.Shadow;
			Output_state = source.Output_state.Shadow;
			Input_cycle_counter = source.Input_cycle_counter.Shadow;
			Output_order_feedback = source.Output_order_feedback.Shadow;
			Events_in_output_buffer = source.Events_in_output_buffer.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowStatus_642C2ED1 source)
		{
			this.CopyShadowToPlain((Plc1.Status_642C2ED1)source);
		}
	}
}