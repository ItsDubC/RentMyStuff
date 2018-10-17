﻿using System;
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

namespace RentMyStuff.Web.Controllers
{
    public class AssetsController : Controller
    {
        private IService<Asset> _assetService;
		private IService<AssetType> _assetTypeService;

		public AssetsController(IService<Asset> assetService, IService<AssetType> assetTypeService)
        {
            _assetService = assetService;
			_assetTypeService = assetTypeService;
		}

        // GET: Assets
        public ViewResult Index()
        {
            var assetDtos = _assetService.GetAll().Select(Mapper.Map<Asset, AssetDto>);
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
				AssetTypes = assetTypes,
				Asset = new Asset()
			};

            return View(viewModel);
        }

        // POST: Assets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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