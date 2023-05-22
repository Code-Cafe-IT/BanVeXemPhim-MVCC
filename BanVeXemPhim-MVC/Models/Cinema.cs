using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BanVeXemPhim_MVC.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo rạp")]
        [Required(ErrorMessage = "Không được để chống Logo rạp chiếu phim")]
        public string Logo { get; set; }
        [Display(Name = "Tên rạp")]
        [Required(ErrorMessage = "Không được để chống tên rạp")]
        public string Name { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Không được để chống mô tả rạp")]
        public string Description { get; set; }

        //Quan hệ 
        public List<Movie> Movies { get; set; }
    }
}
