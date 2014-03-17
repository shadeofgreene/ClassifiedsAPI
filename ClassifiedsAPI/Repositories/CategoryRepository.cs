using ClassifiedsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassifiedsAPI.Repositories
{
	public class CategoryRepository : Controller
	{
		#region Properties
		ClassifiedsEntities _dataContext;
		#endregion

		#region Constructors
		public CategoryRepository(ClassifiedsEntities dataContext)
		{
			_dataContext = dataContext;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Gets the child categories of a category by category ID
		/// </summary>
		/// <param name="categoryId"></param>
		/// <returns></returns>
		public List<Category> GetChildCategories(int categoryId)
		{
			 return _dataContext.Categories.Where(x => x.parentCategory == categoryId).ToList();
		}
		#endregion
	}
}
