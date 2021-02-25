using Application1.Models;
using BusinessLogic.Commands.TextCommands;
using BusinessLogic.DTOs;
using BusinessLogic.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Application1.Controllers
{
    public class TextController : Controller
    {
        protected readonly IReadTextContentDb _dbReader;
        protected readonly IReadTextContentFile _fileReader;
        protected readonly IReadTextContentInput _inputReader;
        protected readonly ICreateTextCommand _createTextCommand;
        protected readonly IGetAllTextsCommand _getAllTextsCommand;

        public TextController(IReadTextContentDb dbReader, IReadTextContentFile fileReader, IReadTextContentInput inputReader, ICreateTextCommand createTextCommand, IGetAllTextsCommand getAllTextsCommand)
        {
            _dbReader = dbReader;
            _fileReader = fileReader;
            _inputReader = inputReader;
            _createTextCommand = createTextCommand;
            _getAllTextsCommand = getAllTextsCommand;
        }

        public IActionResult Index()
        {
            ViewBag.Texts = _getAllTextsCommand.Execute();
            return View();
        }

        [HttpPost]
        public ActionResult CountFromDb(TextViewModel viewModel)
        {
            try
            {
                ViewBag.Number = _dbReader.Execute(viewModel.Id);
            }
            catch (EntityNotFoundException e)
            {
                ViewBag.Message = e.Message;
            }

            return View("CountResult");
        }

        [HttpPost]
        public ActionResult CountFromFile(TextViewModel viewModel)
        {
            try
            {
                ViewBag.Number = _fileReader.Execute(viewModel.File);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }

            return View("CountResult");
        }

        [HttpPost]
        public ActionResult CountFromInput(TextViewModel viewModel)
        {
            ViewBag.Number = _inputReader.Execute(viewModel.Input);
            return View("CountResult");
        }

        [HttpPost]
        public ActionResult CreateText(TextViewModel viewModel)
        {
            _createTextCommand.Execute(new TextDto { Content = viewModel.Content });
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
