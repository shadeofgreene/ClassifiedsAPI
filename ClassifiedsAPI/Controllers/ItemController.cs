using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassifiedsAPI.Repositories;
using ClassifiedsAPI.Models;

namespace ClassifiedsAPI.Controllers
{
	public class ItemController : Controller
	{
		#region Properties
		ItemRepository _itemRepository;
		#endregion
		
		#region Constructors
		public ItemController()
		{
			_itemRepository = new ItemRepository();
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Get Classifieds Item by itemId
		/// </summary>
		/// <param name="itemId"></param>
		/// <returns></returns>
		public Item GetItemById(int? itemId)
		{
			if (itemId.HasValue)
			{
				return _itemRepository.GetItemById(itemId.Value);
			}
			return null;
		}

		/// <summary>
		/// Get classifieds items by categoryId
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<Item> GetAllItemsByCategory(int? id)
		{
			return _itemRepository.GetAllItemsByCategory(id);
		}

		/// <summary>
		/// Save a classifieds item
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public int SaveItem(Item item)
		{
			// TODO
			return -1;
		}

		#endregion

	}
}
