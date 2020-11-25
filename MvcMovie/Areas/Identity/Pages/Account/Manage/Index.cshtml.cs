using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MvcMovie.Areas.Identity.Data;

namespace MvcMovie.Areas.Identity.Pages.Account.Manage
{
  public partial class IndexModel : PageModel
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public IndexModel(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager)
    {
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public string Username { get; set; }

    [TempData]
    public string StatusMessage { get; set; }

    [BindProperty]
    public InputModel Input { get; set; }

    public class InputModel
    {
      [Required]
      [DataType(DataType.Text)]
      [Display(Name = "Full name")]
      public string Name { get; set; }

      [DataType(DataType.Text)]
      public string PrefferedGenre1 { get; set; }

      [DataType(DataType.Text)]
      public string PrefferedGenre2 { get; set; }

      [Phone]
      [Display(Name = "Phone number")]
      public string PhoneNumber { get; set; }
    }

    private async Task LoadAsync(ApplicationUser user)
    {
      var userName = await _userManager.GetUserNameAsync(user);
      var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

      Username = userName;

      Input = new InputModel
      {
        Name = user.Name,
        PrefferedGenre1 = user.PrefferedGenre1,
        PrefferedGenre2 = user.PrefferedGenre2,
        PhoneNumber = phoneNumber
      };
    }

    public async Task<IActionResult> OnGetAsync()
    {
      var user = await _userManager.GetUserAsync(User);
      if (user == null)
      {
        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
      }

      await LoadAsync(user);
      return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
      var user = await _userManager.GetUserAsync(User);
      if (user == null)
      {
        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
      }

      if (!ModelState.IsValid)
      {
        await LoadAsync(user);
        return Page();
      }

      var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
      if (Input.PhoneNumber != phoneNumber)
      {
        var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
        if (!setPhoneResult.Succeeded)
        {
          StatusMessage = "Unexpected error when trying to set phone number.";
          return RedirectToPage();
        }
      }

      if (Input.Name != user.Name)
      {
        user.Name = Input.Name;
      }

      if (Input.PrefferedGenre1 != user.PrefferedGenre1)
      {
        user.PrefferedGenre1 = Input.PrefferedGenre1;
      }

      if (Input.PrefferedGenre2 != user.PrefferedGenre2)
      {
        user.PrefferedGenre2 = Input.PrefferedGenre2;
      }

      await _signInManager.RefreshSignInAsync(user);
      StatusMessage = "Your profile has been updated";
      return RedirectToPage();
    }
  }
}
