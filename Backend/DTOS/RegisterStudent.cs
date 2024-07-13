using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.DTOS;

public class RegisterStudent
{
    [StringLength (10,MinimumLength =3,ErrorMessage = "يجب أن يكون الاسم أكبر من ثلاثة حروف")]
    public string FirstName { get; set; }
    [StringLength (10,MinimumLength =3,ErrorMessage = "يجب أن يكون الاسم أكبر من ثلاثة حروف")]
    public string SecondName { get; set; }
    [StringLength (10,MinimumLength =3,ErrorMessage = "يجب أن يكون الاسم أكبر من ثلاثة حروف")]
    public string ThirdName { get; set; }
    [StringLength (10,MinimumLength =3,ErrorMessage = "يجب أن يكون الاسم أكبر من ثلاثة حروف")]
    public string LastName { get; set; }
    [Phone]
    public string Phone { get; set; }
    [Required]
    public DateOnly DateOfBirth { get; set; }
    [Required]
    public string Gender { get; set; } = string.Empty;
    [Required]
    public int GuardianID { get; set; }
    [Required]
    public int DivisionID { get; set; }
    [StringLength (20,MinimumLength =3,ErrorMessage = "يجب أن يكون اسم المتخدم أكبر من ثلاثة رموز")]
    public string UserName { get; set; }
    [StringLength (30,MinimumLength =8,ErrorMessage = "يجب أن تكون كلمة السر أكبر من ثمانية رموز")]
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    [Required]
    public string UserType { get; set; }
}
