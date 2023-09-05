using Core.Search;
using Core.Search.Models;
using Core.Search.Services;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchQuoteController : ControllerBase
    {
        private readonly SearchQuoteService _searchQuoteService;

        public SearchQuoteController(SearchQuoteService searchQuoteService)
        {
            _searchQuoteService = searchQuoteService;
        }

        [HttpPost("search")]
        public ActionResult<PagedItems<Quote>> Search([FromBody] QuoteFilter quoteFilter)
        {
            if (quoteFilter == null)
            {
                return BadRequest();
            }
            else
            {
                return new ActionResult<PagedItems<Quote>>(_searchQuoteService.Search(quoteFilter));
            }
        }
    }
}
