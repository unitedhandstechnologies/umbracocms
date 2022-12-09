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
	// Mixin Content Type with alias "footerContainer"
	/// <summary>Footer Container</summary>
	public partial interface IFooterContainer : IPublishedElement
	{
		/// <summary>Copyright</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Copyright { get; }

		/// <summary>Disclaimer Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Link DisclaimerLink { get; }

		/// <summary>Facebook Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Link FacebookLink { get; }

		/// <summary>Logo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent FooterLogo { get; }

		/// <summary>Footer Services</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Web.Common.PublishedModels.ListBlock FooterServices { get; }

		/// <summary>Instagram Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Link InstagramLink { get; }

		/// <summary>Offers & Promotions</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Web.Common.PublishedModels.ContactList OffersPromotions { get; }

		/// <summary>Privacy Policy link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Link PrivacyPolicyLink { get; }

		/// <summary>Twitter Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Link TwitterLink { get; }

		/// <summary>Youtube Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.Link YoutubeLink { get; }
	}

	/// <summary>Footer Container</summary>
	[PublishedModel("footerContainer")]
	public partial class FooterContainer : PublishedElementModel, IFooterContainer
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const string ModelTypeAlias = "footerContainer";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<FooterContainer, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public FooterContainer(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Copyright
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("copyright")]
		public virtual string Copyright => GetCopyright(this, _publishedValueFallback);

		/// <summary>Static getter for Copyright</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCopyright(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "copyright");

		///<summary>
		/// Disclaimer Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("disclaimerLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link DisclaimerLink => GetDisclaimerLink(this, _publishedValueFallback);

		/// <summary>Static getter for Disclaimer Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Link GetDisclaimerLink(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Link>(publishedValueFallback, "disclaimerLink");

		///<summary>
		/// Facebook Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("facebookLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link FacebookLink => GetFacebookLink(this, _publishedValueFallback);

		/// <summary>Static getter for Facebook Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Link GetFacebookLink(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Link>(publishedValueFallback, "facebookLink");

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerLogo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent FooterLogo => GetFooterLogo(this, _publishedValueFallback);

		/// <summary>Static getter for Logo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent GetFooterLogo(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(publishedValueFallback, "footerLogo");

		///<summary>
		/// Footer Services
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footerServices")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.ListBlock FooterServices => GetFooterServices(this, _publishedValueFallback);

		/// <summary>Static getter for Footer Services</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Web.Common.PublishedModels.ListBlock GetFooterServices(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Web.Common.PublishedModels.ListBlock>(publishedValueFallback, "footerServices");

		///<summary>
		/// Instagram Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("instagramLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link InstagramLink => GetInstagramLink(this, _publishedValueFallback);

		/// <summary>Static getter for Instagram Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Link GetInstagramLink(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Link>(publishedValueFallback, "instagramLink");

		///<summary>
		/// Offers & Promotions
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offersPromotions")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.ContactList OffersPromotions => GetOffersPromotions(this, _publishedValueFallback);

		/// <summary>Static getter for Offers & Promotions</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Web.Common.PublishedModels.ContactList GetOffersPromotions(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Web.Common.PublishedModels.ContactList>(publishedValueFallback, "offersPromotions");

		///<summary>
		/// Privacy Policy link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("privacyPolicyLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link PrivacyPolicyLink => GetPrivacyPolicyLink(this, _publishedValueFallback);

		/// <summary>Static getter for Privacy Policy link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Link GetPrivacyPolicyLink(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Link>(publishedValueFallback, "privacyPolicyLink");

		///<summary>
		/// Twitter Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("twitterLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link TwitterLink => GetTwitterLink(this, _publishedValueFallback);

		/// <summary>Static getter for Twitter Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Link GetTwitterLink(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Link>(publishedValueFallback, "twitterLink");

		///<summary>
		/// Youtube Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("youtubeLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link YoutubeLink => GetYoutubeLink(this, _publishedValueFallback);

		/// <summary>Static getter for Youtube Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.Link GetYoutubeLink(IFooterContainer that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.Link>(publishedValueFallback, "youtubeLink");
	}
}
