using ClassifiedsAPI.Models;
using ClassifiedsAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassifiedsAPI.Controllers
{
	public class CategoryController : Controller
	{
		#region Properties
		CategoryRepository _categoryRepository;
		#endregion

		#region Constructors
		public CategoryController(CategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
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
			return _categoryRepository.GetChildCategories(categoryId);
		}


		#endregion
	}
}
