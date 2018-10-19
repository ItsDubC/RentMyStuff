using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentMyStuff.Core;
using RentMyStuff.Core.Models;
using RentMyStuff.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RentMyStuff.Core.Dtos;
using RentMyStuff.Web.ViewModels;

namespace RentMyStuff.Web.Controllers
{
    public class AssetsController : Controller
    {
        private IMapper _autoMapper;
        private IService<Asset> _assetService;
		private IService<AssetType> _assetTypeService;

		public AssetsController(IMapper autoMapper, IService<Asset> assetService, IService<AssetType> assetTypeService)
        {
            _autoMapper = autoMapper;
            _assetService = assetService;
			_assetTypeService = assetTypeService;
		}

        // GET: Assets
        public ViewResult Index()
        {
            var assetDtos = _assetService.GetAll().Select(_autoMapper.Map<Asset, AssetDto>);
            return View(assetDtos);
        }

        // GET: Assets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Assets/Create
        public ActionResult Create()
        {
			var assetTypes = _assetTypeService.GetAll();

			var viewModel = new AssetFormViewModel()
			{
				AssetTypes = assetTypes.Select(_autoMapper.Map<AssetType, AssetTypeDto>),
				//Asset = new AssetDto()
			};

            return View(viewModel);
        }

        // POST: Assets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(AssetDto assetDto)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new AssetFormViewModel
                {
                    AssetTypes = _assetTypeService.GetAll().Select(_autoMapper.Map<AssetType, AssetTypeDto>),
                    //Asset = assetDto
                };

                return View("Create", viewModel);
            }
            try
            {
                // TODO: Add insert logic here
                if (assetDto.Id == 0)
                {
                    assetDto.NumberAvailable = assetDto.NumberInStock;

                    _assetService.Add(_autoMapper.Map<AssetDto, Asset>(assetDto));
                }
                else
                {
                    var assetInDb = _assetService.GetById(assetDto.Id);

                    assetInDb.Name = assetDto.Name;
                    assetInDb.Description = assetDto.Description;
                    assetInDb.AssetTypeId = assetDto.AssetTypeId;
                    assetInDb.NumberInStock = assetDto.NumberInStock;
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Assets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Assets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Assets/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}