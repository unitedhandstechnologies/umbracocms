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
	/// <summary>Home Page</summary>
	[PublishedModel("oHome")]
	public partial class OHome : PublishedContentModel, IOFooterContainer, IOHeader, IOMetaData, IXmlSiteMapSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const string ModelTypeAlias = "oHome";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<OHome, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public OHome(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Code: Please enter the code that you can get by setting up your page at https://www.facebook.com/
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oCodeFacebookMessages")]
		public virtual string OCodeFacebookMessages => this.Value<string>(_publishedValueFallback, "oCodeFacebookMessages");

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oContent")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent OContent => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "oContent");

		///<summary>
		/// Noscript
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oTagManagerNoscript")]
		public virtual string OTagManagerNoscript => this.Value<string>(_publishedValueFallback, "oTagManagerNoscript");

		///<summary>
		/// Script
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oTagManagerScript")]
		public virtual string OTagManagerScript => this.Value<string>(_publishedValueFallback, "oTagManagerScript");

		///<summary>
		/// Contacts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oContacts")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.OContactList OContacts => global::Umbraco.Cms.Web.Common.PublishedModels.OFooterContainer.GetOContacts(this, _publishedValueFallback);

		///<summary>
		/// Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oFooterLogo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent OFooterLogo => global::Umbraco.Cms.Web.Common.PublishedModels.OFooterContainer.GetOFooterLogo(this, _publishedValueFallback);

		///<summary>
		/// Footer navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oFooterNavigation")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.OListBlock OFooterNavigation => global::Umbraco.Cms.Web.Common.PublishedModels.OFooterContainer.GetOFooterNavigation(this, _publishedValueFallback);

		///<summary>
		/// Footer Services
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oServices")]
		public virtual global::Umbraco.Cms.Web.Common.PublishedModels.OListBlock OServices => global::Umbraco.Cms.Web.Common.PublishedModels.OFooterContainer.GetOServices(this, _publishedValueFallback);

		///<summary>
		/// Social Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oSocialLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SocialLink> OSocialLinks => global::Umbraco.Cms.Web.Common.PublishedModels.OFooterContainer.GetOSocialLinks(this, _publishedValueFallback);

		///<summary>
		/// Burger menu caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oBurgerMenuCaption")]
		public virtual string OBurgerMenuCaption => global::Umbraco.Cms.Web.Common.PublishedModels.OHeader.GetOBurgerMenuCaption(this, _publishedValueFallback);

		///<summary>
		/// Contact page link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oContactPageLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link OContactPageLink => global::Umbraco.Cms.Web.Common.PublishedModels.OHeader.GetOContactPageLink(this, _publishedValueFallback);

		///<summary>
		/// Header logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oHeaderLogo")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent OHeaderLogo => global::Umbraco.Cms.Web.Common.PublishedModels.OHeader.GetOHeaderLogo(this, _publishedValueFallback);

		///<summary>
		/// Header Menu Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oHeaderMenuItems")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.OHeaderMenuItem> OHeaderMenuItems => global::Umbraco.Cms.Web.Common.PublishedModels.OHeader.GetOHeaderMenuItems(this, _publishedValueFallback);

		///<summary>
		/// Header menu social links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oHeaderMenuSocialLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SocialLink> OHeaderMenuSocialLinks => global::Umbraco.Cms.Web.Common.PublishedModels.OHeader.GetOHeaderMenuSocialLinks(this, _publishedValueFallback);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oMetaDescription")]
		public virtual string OMetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.OMetaData.GetOMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Meta Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("oMetaName")]
		public virtual string OMetaName => global::Umbraco.Cms.Web.Common.PublishedModels.OMetaData.GetOMetaName(this, _publishedValueFallback);

		///<summary>
		/// Index links: Should search engines follow links on this page?
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[ImplementPropertyType("oRobotsFollow")]
		public virtual bool ORobotsFollow => global::Umbraco.Cms.Web.Common.PublishedModels.OMetaData.GetORobotsFollow(this, _publishedValueFallback);

		///<summary>
		/// Index a page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[ImplementPropertyType("oRobotsIndex")]
		public virtual bool ORobotsIndex => global::Umbraco.Cms.Web.Common.PublishedModels.OMetaData.GetORobotsIndex(this, _publishedValueFallback);

		///<summary>
		/// Hide From Xml Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[ImplementPropertyType("hideFromXmlSitemap")]
		public virtual bool HideFromXmlSitemap => global::Umbraco.Cms.Web.Common.PublishedModels.XmlSiteMapSettings.GetHideFromXmlSitemap(this, _publishedValueFallback);

		///<summary>
		/// Search Engine Change Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("searchEngineChangeFrequency")]
		public virtual string SearchEngineChangeFrequency => global::Umbraco.Cms.Web.Common.PublishedModels.XmlSiteMapSettings.GetSearchEngineChangeFrequency(this, _publishedValueFallback);

		///<summary>
		/// Search Engine Relative Priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.3.2+e7fae14")]
		[ImplementPropertyType("searchEngineRelativePriority")]
		public virtual decimal SearchEngineRelativePriority => global::Umbraco.Cms.Web.Common.PublishedModels.XmlSiteMapSettings.GetSearchEngineRelativePriority(this, _publishedValueFallback);
	}
}
