using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdsMes.WEB.Models
{
    public class ChecklistViewModel
    {
        //[Display(Name = "Дата")]
        //[DataType(DataType.Date)]
        //public DateTime Date { get; set; }
        public long ID { get; set; }
        
        [Display(Name = "Дата и Время")]
        //[DataType(DataType.Time)]
        public DateTime DateTime { get; set; }

        [Required]
        [Display(Name = "Отметка о соответствии")]
        public string Conformity { get; set; }

        [Required]
        [Display(Name = "Расслоение вверху")]
        public string Top { get; set; }

        [Required]
        [Display(Name = "Расслоение  внизу")]
        public string Bottom { get; set; }

        [Required]
        [Display(Name = "Расслоение слева")]
        public string Left { get; set; }

        [Required]
        [Display(Name = "Расслоение справа")]
        public string Right { get; set; }

        [Required]
        [Display(Name = "Длина панели, мм")]
        public int Length { get; set; }

        [Display(Name = "Штрихкод")]
        public string Barcode { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Рабочее место")]
        public string Workplace { get; set; }

        [Required]
        [Display(Name = "Номер смены")]
        public int ShiftNumber { get; set; }
        //[HiddenInput(DisplayValue = false)]        
    }
}