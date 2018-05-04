//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IContentBase, IHero, ISeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Featured products
		///</summary>
		[ImplementPropertyType("featuredProducts")]
		public IEnumerable<IPublishedContent> FeaturedProducts
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("featuredProducts"); }
		}

		///<summary>
		/// Body text
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return Umbraco.Web.PublishedContentModels.ContentBase.GetBodyText(this); }
		}

		///<summary>
		/// Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.ContentBase.GetHeadline(this); }
		}

		///<summary>
		/// Hero image
		///</summary>
		[ImplementPropertyType("heroImage")]
		public IPublishedContent HeroImage
		{
			get { return Umbraco.Web.PublishedContentModels.Hero.GetHeroImage(this); }
		}

		///<summary>
		/// Hero text
		///</summary>
		[ImplementPropertyType("heroText")]
		public string HeroText
		{
			get { return Umbraco.Web.PublishedContentModels.Hero.GetHeroText(this); }
		}

		///<summary>
		/// Meta description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.Seo.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Seo.GetMetaTitle(this); }
		}

		///<summary>
		/// No index
		///</summary>
		[ImplementPropertyType("noIndex")]
		public bool NoIndex
		{
			get { return Umbraco.Web.PublishedContentModels.Seo.GetNoIndex(this); }
		}
	}
}
