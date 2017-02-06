using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdsMes.WEB.Models
{
    public class DrillCardViewModel
    {

        public long ID { get; set; }

        [Display(Name = "Дата и Время")]
        public DateTime DateTime { get; set; }

        [Required]
        [Display(Name = "№ пары")]
        public int PairNumber { get; set; }

        [Required]
        [Display(Name = "Верхняя головка")]
        public string UpperHead { get; set; }

        [Required]
        [Display(Name = "Нижняя головка")]
        public string LowerHead { get; set; }

        [Required]
        [Display(Name = "Ресурс (количество операций)")]
        public int Resource { get; set; }

        [Required]
        [Display(Name = "Производитель")]
        public string Manufacter { get; set; }

        [Required]
        [Display(Name = "Сверло: Новое")]
        public string NewDrill { get; set; }

        [Required]
        [Display(Name = "Сверло: Переточка")]
        public string SharpenDrill { get; set; }

        [Required]
        [Display(Name = "Исполнитель")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Номер смены")]
        public int ShiftNumber { get; set; }
    }
}