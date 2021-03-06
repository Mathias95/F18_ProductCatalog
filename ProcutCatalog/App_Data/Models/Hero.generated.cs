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
	// Mixin content Type 1087 with alias "hero"
	/// <summary>Hero</summary>
	public partial interface IHero : IPublishedContent
	{
		/// <summary>Hero image</summary>
		IPublishedContent HeroImage { get; }

		/// <summary>Hero text</summary>
		string HeroText { get; }
	}

	/// <summary>Hero</summary>
	[PublishedContentModel("hero")]
	public partial class Hero : PublishedContentModel, IHero
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "hero";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Hero(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Hero, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hero image
		///</summary>
		[ImplementPropertyType("heroImage")]
		public IPublishedContent HeroImage
		{
			get { return GetHeroImage(this); }
		}

		/// <summary>Static getter for Hero image</summary>
		public static IPublishedContent GetHeroImage(IHero that) { return that.GetPropertyValue<IPublishedContent>("heroImage"); }

		///<summary>
		/// Hero text
		///</summary>
		[ImplementPropertyType("heroText")]
		public string HeroText
		{
			get { return GetHeroText(this); }
		}

		/// <summary>Static getter for Hero text</summary>
		public static string GetHeroText(IHero that) { return that.GetPropertyValue<string>("heroText"); }
	}
}
