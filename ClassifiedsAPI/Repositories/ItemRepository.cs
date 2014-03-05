using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassifiedsAPI.Models;

namespace ClassifiedsAPI.Repositories
{
	public class ItemRepository : Controller
	{
		#region Properties
		ClassifiedsEntities _dataContext;
		#endregion

		#region Constructors
		public ItemRepository()
		{
			_dataContext = new ClassifiedsEntities();
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Gets a classifieds item by itemId
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public Item GetItemById(int itemId)
		{
			try
			{
				return _dataContext.Items.Where(x => x.itemId == itemId).FirstOrDefault();
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// Get classifieds items by categoryId
		/// </summary>
		/// <param name="categoryId"></param>
		/// <returns></returns>
		public List<Item> GetAllItemsByCategory(int? categoryId)
		{
			try
			{
				var items = (from i in _dataContext.Items
							 from c in _dataContext.Categories
							 where c.categoryId == categoryId
							 select i).ToList();
				return items;
			}
			catch
			{
				return null;
			}
		}

		/// <summary>
		/// Add Classifieds Item to DB
		/// </summary>
		/// <param name="categoryId"></param>
		/// <returns></returns>
		public int SaveItem(Item item)
		{
			try
			{
				_dataContext.Items.Add(item);
				_dataContext.SaveChanges();
				return 200;
			}
			catch
			{
				return 500;
			}
		}
		#endregion
	}
}
