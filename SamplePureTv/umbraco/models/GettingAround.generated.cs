//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.3.2+e7fae14
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Getting Around</summary>
	[PublishedModel("gettingAround")]
	public partial class GettingAround : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const string ModelTypeAlias = "gettingAround";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<GettingAround, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public GettingAround(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Bus Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("busDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString BusDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "busDescription");

		///<summary>
		/// Bus Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("busImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops BusImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "busImage");

		///<summary>
		/// Bus Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("busSubtitle")]
		public virtual string BusSubtitle => this.Value<string>(_publishedValueFallback, "busSubtitle");

		///<summary>
		/// Bus Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("busTitle")]
		public virtual string BusTitle => this.Value<string>(_publishedValueFallback, "busTitle");

		///<summary>
		/// Car Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("carDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString CarDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "carDescription");

		///<summary>
		/// Car Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("carImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops CarImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "carImage");

		///<summary>
		/// Car Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("carSubtitle")]
		public virtual string CarSubtitle => this.Value<string>(_publishedValueFallback, "carSubtitle");

		///<summary>
		/// Car Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("carTitle")]
		public virtual string CarTitle => this.Value<string>(_publishedValueFallback, "carTitle");

		///<summary>
		/// Flight Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("flightDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString FlightDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "flightDescription");

		///<summary>
		/// Flight Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("flightImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FlightImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "flightImage");

		///<summary>
		/// Flight Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("flightSubtitle")]
		public virtual string FlightSubtitle => this.Value<string>(_publishedValueFallback, "flightSubtitle");

		///<summary>
		/// Flight Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("flightTitle")]
		public virtual string FlightTitle => this.Value<string>(_publishedValueFallback, "flightTitle");

		///<summary>
		/// GettingAround Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gettingAroundContent")]
		public virtual string GettingAroundContent => this.Value<string>(_publishedValueFallback, "gettingAroundContent");

		///<summary>
		/// GettingAround Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gettingAroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops GettingAroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "gettingAroundImage");

		///<summary>
		/// GettingAround Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gettingAroundSubtitle")]
		public virtual string GettingAroundSubtitle => this.Value<string>(_publishedValueFallback, "gettingAroundSubtitle");

		///<summary>
		/// GettingAround Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gettingAroundTitle")]
		public virtual string GettingAroundTitle => this.Value<string>(_publishedValueFallback, "gettingAroundTitle");

		///<summary>
		/// Left Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("leftSection")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> LeftSection => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "leftSection");

		///<summary>
		/// Left Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("leftSectionBus")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> LeftSectionBus => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "leftSectionBus");

		///<summary>
		/// Left Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("leftSectionFlight")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> LeftSectionFlight => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "leftSectionFlight");

		///<summary>
		/// Left Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("leftSectionTrain")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> LeftSectionTrain => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "leftSectionTrain");

		///<summary>
		/// Mail Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mailContent")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails> MailContent => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails>>(_publishedValueFallback, "mailContent");

		///<summary>
		/// Mail Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mailContentBus")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails> MailContentBus => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails>>(_publishedValueFallback, "mailContentBus");

		///<summary>
		/// Mail Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mailContentFlight")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails> MailContentFlight => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails>>(_publishedValueFallback, "mailContentFlight");

		///<summary>
		/// Mail Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mailContentTrain")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails> MailContentTrain => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.MailDetails>>(_publishedValueFallback, "mailContentTrain");

		///<summary>
		/// Middle Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("middleSection")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> MiddleSection => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "middleSection");

		///<summary>
		/// Middle Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("middleSectionBus")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> MiddleSectionBus => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "middleSectionBus");

		///<summary>
		/// Middle Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("middleSectionFlight")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> MiddleSectionFlight => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "middleSectionFlight");

		///<summary>
		/// Middle Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("middleSectionTrain")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> MiddleSectionTrain => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "middleSectionTrain");

		///<summary>
		/// Right Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightSection")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> RightSection => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "rightSection");

		///<summary>
		/// Right Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightSectionBus")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> RightSectionBus => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "rightSectionBus");

		///<summary>
		/// Right Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightSectionFlight")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> RightSectionFlight => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "rightSectionFlight");

		///<summary>
		/// Right Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rightSectionTrain")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription> RightSectionTrain => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.VehicleTitleDescription>>(_publishedValueFallback, "rightSectionTrain");

		///<summary>
		/// Train Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trainDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString TrainDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "trainDescription");

		///<summary>
		/// Train Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trainImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops TrainImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "trainImage");

		///<summary>
		/// Train Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trainSubtitle")]
		public virtual string TrainSubtitle => this.Value<string>(_publishedValueFallback, "trainSubtitle");

		///<summary>
		/// Train Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trainTitle")]
		public virtual string TrainTitle => this.Value<string>(_publishedValueFallback, "trainTitle");
	}
}
