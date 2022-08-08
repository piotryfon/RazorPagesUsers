using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUsers.Services;
using RazorPagesUsers.UserModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesUsers.Pages.UserPages
{
    public class PaginatedUsersModel : PageModel
    {
        private readonly IUserService _userService;

        public PaginatedUsersModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 5;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public List<User> Data { get; set; }
        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public async Task OnGetAsync()
        {
            Data = await _userService.GetPaginatedResult(CurrentPage, PageSize);
            Count = await _userService.GetCount();
        }
    }
}
