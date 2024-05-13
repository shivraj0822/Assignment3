using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vidhyalaya.Pages_Student
{
    public class CreateModel : PageModel
    {
        private readonly VidhyalayaDbContext _context;

        public CreateModel(VidhyalayaDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
             ViewData["GradeId"] = new SelectList(_context.Grade, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
