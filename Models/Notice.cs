using System.ComponentModel.DataAnnotations;

namespace ToyProject.Models
{
    public class Notice
    {
        [Key]
        public int Id {  get; set; }

        [Display(Name = "아이디", Prompt = "영문숫자 포함 50자리")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "{0}는 {2}~{1}문자여야 합니다. ")]
        [Required(ErrorMessage = "사용하실 아이디를 입력해주세요.")]
        public string? UserId { get; set; }

        [Display(Name = "이름", Prompt = "영문숫자 포함 50자리")]
        [StringLength(50)]
        [Required(ErrorMessage = "사용하실 이름를 입력해주세요.")]
        public string? Name { get; set; }

        public DateTime? Regdate { get; set; }
    }
}