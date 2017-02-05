using AdsMes.WEB.Models;
using AutoMapper;
using Kraft.BLL.DTO;
using Kraft.BLL.Infrastructure;
using Kraft.BLL.Interfaces;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdsMes.WEB.Controllers
{
    public class HomeController : Controller
    {
        IKraftService kraftService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="_kraftService"></param>
        public HomeController(IKraftService _kraftService)
        {
            kraftService = _kraftService;
        }

        /// <summary>
        /// Главная страница
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Форма заполнения карты проверки
        /// </summary>
        /// <returns></returns>
        public ActionResult ChecklistCreate()
        {
            ChecklistViewModel checklist = new ChecklistViewModel();
            return View(checklist);
        }

        /// <summary>
        /// Заполненая форма карты проверка
        /// </summary>
        /// <param name="checklist"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChecklistCreate(ChecklistViewModel checklist)
        {
            try
            {
                Mapper.Initialize(cfg => cfg.CreateMap<ChecklistViewModel, ChecklistDTO>());
                var checklistDto = Mapper.Map<ChecklistViewModel, ChecklistDTO>(checklist);
                kraftService.CreateChecklist(checklistDto);
                return View("ChecklistCreateSuccess");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(checklist);
        }

        /// <summary>
        /// Просмотр таблицы контрольных карт
        /// </summary>
        /// <returns></returns>
        public object ChecklistViewAll(int? page)
        {
            IEnumerable<ChecklistDTO> checklistDtos = kraftService.GetChecklists();
            Mapper.Initialize(cfg => cfg.CreateMap<ChecklistDTO, ChecklistViewModel>());
            var checklists = Mapper.Map<IEnumerable<ChecklistDTO>, List<ChecklistViewModel>>(checklistDtos);

            int perPage = 10;
            int pageNumber = page ?? ((checklists.Count / perPage) + 1);
            return View(checklists.ToPagedList(pageNumber, perPage));
        }

        /// <summary>
        /// Форма заполнения карты свёрл
        /// </summary>
        /// <returns></returns>
        public ActionResult DrillCardCreate()
        {
            DrillCardViewModel drillCard = new DrillCardViewModel();
            return View(drillCard);
        }

        /// <summary>
        /// Заполненая форма карты свёрл
        /// </summary>
        /// <param name="drillCard"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DrillCardCreate(DrillCardViewModel drillCard)
        {
            try
            {
                Mapper.Initialize(cfg => cfg.CreateMap<DrillCardViewModel, DrillCardDTO>());
                var drillCardDto = Mapper.Map<DrillCardViewModel, DrillCardDTO>(drillCard);
                kraftService.CreateDrillCard(drillCardDto);
                return View("DrillCardCreateSuccess");
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(drillCard);
        }

        /// <summary>
        /// Просмотр таблицы карт замены свёрл
        /// </summary>
        /// <returns></returns>
        public object DrillCardViewAll(int? page)
        {
            IEnumerable<DrillCardDTO> drillcardDtos = kraftService.GetDrillCards();
            Mapper.Initialize(cfg => cfg.CreateMap<DrillCardDTO, DrillCardViewModel>());
            var drillCards = Mapper.Map<IEnumerable<DrillCardDTO>, List<DrillCardViewModel>>(drillcardDtos);

            int perPage = 10;
            int pageNumber = page ?? ((drillCards.Count / perPage) + 1);
            return View(drillCards.ToPagedList(pageNumber, perPage));
        }

        /// <summary>
        /// About page
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "В разработке...";

            return View();
        }

        /// <summary>
        /// Контакты
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Контактные данные.";

            return View();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            kraftService.Dispose();
            base.Dispose(disposing);
        }
    }
}