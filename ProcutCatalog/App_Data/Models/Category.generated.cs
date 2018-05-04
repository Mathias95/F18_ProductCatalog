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
	/// <summary>Category</summary>
	[PublishedContentModel("category")]
	public partial class Category : PublishedContentModel, IProductsBase, ISeo
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "category";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Category(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Category, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Products
		///</summary>
		[ImplementPropertyType("products")]
		public IEnumerable<IPublishedContent> Products
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("products"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("pImage")]
		public IPublishedContent PImage
		{
			get { return Umbraco.Web.PublishedContentModels.ProductsBase.GetPImage(this); }
		}

		///<summary>
		/// Name
		///</summary>
		[ImplementPropertyType("pName")]
		public string PName
		{
			get { return Umbraco.Web.PublishedContentModels.ProductsBase.GetPName(this); }
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
