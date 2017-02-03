using Kraft.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraft.BLL.Interfaces
{
    public interface IKraftService
    {
        void CreateChecklist(ChecklistDTO checklistDto);
        IEnumerable<ChecklistDTO> GetChecklists();

        void CreateDrillCard(DrillCardDTO drillCardDto);
        IEnumerable<DrillCardDTO> GetDrillCards();
        void Dispose();
    }
}
