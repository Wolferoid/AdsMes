using Kraft.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kraft.BLL.DTO;
using Kraft.DAL.Interfaces;
using Kraft.DAL.Entities;
using AuxiliaryLibrary;
using AutoMapper;

namespace Kraft.BLL.Services
{
    public class KraftService : IKraftService
    {
        IUnitOfWork Database { get; set; }

        public KraftService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void CreateChecklist(ChecklistDTO checklistDto)
        {
            Checklist checklist = new Checklist
            {
                DateTime = DateTime.Now,
                Conformity = checklistDto.Conformity,
                Top = checklistDto.Top,
                Bottom = checklistDto.Bottom,
                Left = checklistDto.Left,
                Right = checklistDto.Right,
                Length = checklistDto.Length,
                Barcode = checklistDto.Barcode,
                UserName = checklistDto.UserName,
                Workplace = checklistDto.Workplace,
                ShiftNumber = checklistDto.ShiftNumber
            };

            Database.Checklists.Create(checklist);
            Database.Save();
        }

        public IEnumerable<ChecklistDTO> GetChecklists()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Checklist, ChecklistDTO>());
            return Mapper.Map<IEnumerable<Checklist>, List<ChecklistDTO>>(Database.Checklists.GetAll());
        }

        public void CreateDrillCard(DrillCardDTO drillCardDto)
        {
            DrillCard drillCard = new DrillCard
            {
                DateTime = DateTime.Now,
                PairNumber = drillCardDto.PairNumber,
                UpperHead = drillCardDto.UpperHead,
                LowerHead = drillCardDto.LowerHead,
                Resource = drillCardDto.Resource,
                Manufacter = drillCardDto.Manufacter,
                NewDrill = drillCardDto.NewDrill,
                SharpenDrill = drillCardDto.SharpenDrill,
                UserName = drillCardDto.UserName,
                ShiftNumber = drillCardDto.ShiftNumber
            };
            Database.DrillCards.Create(drillCard);
            Database.Save();
        }

        public IEnumerable<DrillCardDTO> GetDrillCards()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<DrillCard, DrillCardDTO>());
            return Mapper.Map<IEnumerable<DrillCard>, List<DrillCardDTO>>(Database.DrillCards.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
