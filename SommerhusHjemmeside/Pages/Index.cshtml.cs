using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Formats.Asn1;

namespace SommerhusHjemmeside.Pages
{
    public class IndexModel : PageModel
    {

        //// Repository for data (dependency injection)
        //private ISommerHouseRepository _list;


        //// Contructor
        //public IndexModel(ISommerHouseRepository list)
        //{
        //    _list = list;
        //}

        //// List property
        //public List<SommerHouse> SommerHouses { get; set; }

        //// BindProperties
        //[BindProperty]
        //public string? Search { get; set; }
        //[BindProperty]
        //public string? Search { get; set; }

        //// HTTP GET method to handle intial page loading:
        //public void OnGet()
        //{
        //    SommerHouses = _list.GetAllSommerHouse();
        //}


        //// HTTP POST method to handle form submissions:
        //public RedirectToPageResult OnPost()
        //{
        //    return RedirectToPage("Index");
        //}

        //public IActionResult OnPostSearch()
        //{
        //    SommerHouse = _list.Search(Search);
        //    return Page();
        //}

        //public RedirectToPageResult OnPostOrder()
        //{
        //    return RedirectToPage("Index");
        //}
    }
}
